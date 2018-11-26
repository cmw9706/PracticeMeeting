using System;
using System.Collections.Generic;
using PracticeMeeting.Services;
using Xamarin.Forms;

namespace PracticeMeeting.Views
{
    public partial class PracticeMeetingListPage : ContentPage
    {
        public PracticeMeetingListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var dataService = new GenericDataService();

            practiceMeetingList.ItemsSource = dataService.GetPracticeMeetings();
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedItem = e.SelectedItem;

            if(selectedItem != null)
                await Navigation.PushAsync(new PracticeMeetingDetailsPage(selectedItem));

            practiceMeetingList.SelectedItem = null;
        }
    }
}
