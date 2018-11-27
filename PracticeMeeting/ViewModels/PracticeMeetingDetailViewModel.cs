using System;
using GalaSoft.MvvmLight;
using PracticeMeeting.Models;

namespace PracticeMeeting.ViewModels
{
    public class PracticeMeetingDetailViewModel : ViewModelBase
    {
        private PracticeMeetingModel _selectedMeeting;

        public PracticeMeetingModel SelectedMeeting
        {
            get => _selectedMeeting;
            set
            {
                _selectedMeeting = value;
                RaisePropertyChanged(nameof(SelectedMeeting));
            }
        }
        public PracticeMeetingDetailViewModel(PracticeMeetingModel practiceMeeting)
        {
            SelectedMeeting = practiceMeeting;
        }
    }
}
