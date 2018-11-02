/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Autofac;
using DRS_Mobile_MVVM.Models;
using DRS_Mobile_MVVM.Services;
using DRS_Mobile_MVVM.IServices;
using DRS_Mobile_MVVM.IViewModels;
using DRS_Mobile_MVVM.Repositories;
using Xamarin.Forms.Popups;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Navigation;

namespace DRS_Mobile_MVVM.ViewModels
{
    public class ViewModelLocator
    {
        private IContainer _container;

        [Preserve]
        public ViewModelLocator()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<HomeViewModel>().As<IHomeViewModel>().SingleInstance();
            builder.RegisterType<DetailsViewModel>().As<IDetailsViewModel>().SingleInstance();

            builder.RegisterType<UserServices>().As<IUserServices>().SingleInstance();
            builder.RegisterType<PopupsService>().As<IPopupsService>().SingleInstance();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            builder.RegisterType<Repository<TodoItem>>().As<IRepository<TodoItem>>().SingleInstance();

            _container = builder.Build();
        }

        public IHomeViewModel Home
        {
            get
            {
                return _container.Resolve<IHomeViewModel>();
            }
        }

        public IDetailsViewModel Details
        {
            get
            {
                return _container.Resolve<IDetailsViewModel>();
            }
        }
    }
}
