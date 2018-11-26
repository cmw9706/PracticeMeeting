using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracticeMeeting.Views
{
    public partial class PracticeMeetingDetailsPage : ContentPage
    {
        public PracticeMeetingDetailsPage(object selectedMeeting)
        {
            InitializeComponent();

            detailsGrid.BindingContext = selectedMeeting;
        }
    }
}
