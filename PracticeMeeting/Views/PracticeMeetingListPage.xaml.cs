using PracticeMeeting.ViewModels;
using Xamarin.Forms;

namespace PracticeMeeting.Views
{
    public partial class PracticeMeetingListPage : ContentPage
    {
        private PracticeMeetingListViewModel ViewModel;

        public PracticeMeetingListPage()
        {
            InitializeComponent();

            BindingContext = new PracticeMeetingListViewModel();

            ViewModel = (PracticeMeetingListViewModel)BindingContext;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ViewModel.GetMeetings();

            ViewModel.PropertyChanged += Handle_PropertyChanged;
        }
        protected override void OnDisappearing()
        {
            ViewModel.PropertyChanged -= Handle_PropertyChanged;

            base.OnDisappearing();
        }

        void Handle_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName.Equals(nameof(ViewModel.SelectedMeeting)) && ViewModel.SelectedMeeting != null)
            {
                Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
                {
                    var detailsVM = new PracticeMeetingDetailViewModel(ViewModel.SelectedMeeting);
                    await Navigation.PushAsync(new PracticeMeetingDetailsPage(detailsVM));

                    ViewModel.SelectedMeeting = null;
                });
            }
        }
    }
}
