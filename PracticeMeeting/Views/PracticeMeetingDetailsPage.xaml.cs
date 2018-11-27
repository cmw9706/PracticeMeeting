using System;
using System.Collections.Generic;
using PracticeMeeting.ViewModels;
using Xamarin.Forms;

namespace PracticeMeeting.Views
{
    public partial class PracticeMeetingDetailsPage : ContentPage
    {
        public PracticeMeetingDetailsPage(PracticeMeetingDetailViewModel selectedMeeting)
        {
            InitializeComponent();

            detailsGrid.BindingContext = selectedMeeting;
        }
    }
}
