using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using OnTheRoadTravelSearch.ViewModel;

namespace OnTheRoadTravelSearch.App
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SearchTravelViewModel>();
            SimpleIoc.Default.Register<TravelDetailViewModel>();
        }

        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public SearchTravelViewModel SearchTravelViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SearchTravelViewModel>();
            }
        }

        public TravelDetailViewModel TravelDetailViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TravelDetailViewModel>();
            }
        }

    }
}