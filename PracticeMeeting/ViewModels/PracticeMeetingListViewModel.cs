using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PracticeMeeting.Models;
using PracticeMeeting.Services;

namespace PracticeMeeting.ViewModels
{
    public class PracticeMeetingListViewModel : ViewModelBase
    {
        private ObservableCollection<PracticeMeetingModel> _practiceMeetings;
        private PracticeMeetingModel _selectedMeeting;

        public ObservableCollection<PracticeMeetingModel> PracticeMeetings
        {
            get => _practiceMeetings;
            set
            {
                _practiceMeetings = value;
                RaisePropertyChanged(nameof(PracticeMeetings));
            }
        }

        public PracticeMeetingModel SelectedMeeting
        {
            get => _selectedMeeting;
            set
            {
                _selectedMeeting = value;
                RaisePropertyChanged(nameof(SelectedMeeting));
            }
        }

        public PracticeMeetingListViewModel()
        {

        }

        public void GetMeetings()
        {
            var dataService = new GenericDataService();

            PracticeMeetings = dataService.GetPracticeMeetings();
        }
    }
}
