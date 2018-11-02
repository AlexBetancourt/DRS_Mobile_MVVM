/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Xamarin.Forms;
using DRS_Mobile_MVVM.Models;
using DRS_Mobile_MVVM.IViewModels;
using DRS_Mobile_MVVM.Repositories;
using System.Windows.Input;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Navigation;
using System.Collections.ObjectModel;
using DRS_Mobile.Models;

namespace DRS_Mobile_MVVM.ViewModels
{
    public class HomeViewModel : BaseViewModel, IHomeViewModel
    {
        private IRepository<Mech> _iMechItemRepository;

        private ObservableCollection<Mech> _MechItems;
        public ObservableCollection<Mech> MechItems
        {
            get { return _MechItems; }
            set
            {
                _MechItems = value;
                OnPropertyChanged(nameof(MechItems));
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand SelectedItemCommand { get; set; }

        [Preserve]
        public HomeViewModel(IRepository<Mech> _iMechItemRepository,
            INavigationService _iNavigationService)
        {
            this._iNavigationService = _iNavigationService;
            this._iMechItemRepository = _iMechItemRepository;

            AddCommand = new Command(Add);
            SelectedItemCommand = new Command<Mech>(SelectedItem);

            MessagingCenter.Subscribe<string>(this, "HomeViewLoadedMessage", InitData);
        }

        private async void InitData(string message)
        {
            var result = await _iMechItemRepository.Get();
            if (result != null && result.Count > 0)
            {
                MechItems = new ObservableCollection<Mech>(result);
            }
            else
            {
                MechItems = new ObservableCollection<Mech>();
            }
        }

        private async void Add()
        {
            await _iNavigationService.NavigateTo("DetailsView", null);
        }

        private async void SelectedItem(Mech param)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add(nameof(Mech), param);
            await _iNavigationService.NavigateTo("DetailsView", navigationParams);
        }
    }
}
