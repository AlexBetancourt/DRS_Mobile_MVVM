/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Xamarin.Forms;
using DRS_Mobile_MVVM.Models;
using DRS_Mobile_MVVM.IViewModels;
using DRS_Mobile_MVVM.Repositories;
using Xamarin.Forms.Popups;
using System.Windows.Input;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Navigation;
using DRS_Mobile.Models;

namespace DRS_Mobile_MVVM.ViewModels
{
    public class DetailsViewModel : BaseViewModel, IDetailsViewModel
    {
        private IRepository<Mech> _iMechItemRepository;

        private Mech _currentMechItem;
        public Mech CurrentMechItem
        {
            get { return _currentMechItem; }
            set
            {
                _currentMechItem = value;
                OnPropertyChanged(nameof(CurrentMechItem));
            }
        }

        private bool _isDeleteVisible;
        public bool IsDeleteVisible
        {
            get { return _isDeleteVisible; }
            set
            {
                _isDeleteVisible = value;
                OnPropertyChanged(nameof(IsDeleteVisible));
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        [Preserve]
        public DetailsViewModel(IRepository<Mech> _iMechItemRepository,
            IPopupsService _iPopupsService,
            INavigationService _iNavigationService)
        {
            this._iPopupsService = _iPopupsService;
            this._iNavigationService = _iNavigationService;
            this._iMechItemRepository = _iMechItemRepository;

            SaveCommand = new Command(Save);
            DeleteCommand = new Command(Delete);

            MessagingCenter.Subscribe<string>(this, "DetailsViewLoadedMessage", InitData);
        }

        private void InitData(string message)
        {
            if (_iNavigationService.GetParameters() != null)
            {
                CurrentMechItem = _iNavigationService.GetParameters().GetValue<Mech>(nameof(Mech));
                IsDeleteVisible = true;
                return;
            }

            IsDeleteVisible = false;
            CurrentMechItem = new Mech();
        }

        private async void Save()
        {
            if (IsDeleteVisible)
            {
                await _iMechItemRepository.Update(CurrentMechItem);
            }
            else
            {
                await _iMechItemRepository.Insert(CurrentMechItem);
            }
            await _iNavigationService.GoBack();
        }

        private async void Delete()
        {
            await _iMechItemRepository.Delete(CurrentMechItem);
            await _iNavigationService.GoBack();
        }
    }
}
