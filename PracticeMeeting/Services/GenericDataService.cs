using System;
using System.Collections.ObjectModel;
using PracticeMeeting.Models;

namespace PracticeMeeting.Services
{
    public class GenericDataService
    {
        private static readonly ObservableCollection<PracticeMeetingModel> _practiceMeetings = new ObservableCollection<PracticeMeetingModel>
        {
            new PracticeMeetingModel
            {
                Speaker = "Connor Williams",
                Date = DateTimeOffset.Now,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Topic = "Xamarin.Forms Development"
            },
            new PracticeMeetingModel
            {
                Speaker = "Gary Meyer",
                Date = DateTimeOffset.Now.Subtract(TimeSpan.FromDays(30)),
                Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Topic = "UX Design with Figma"
            }
        };

        public ObservableCollection<PracticeMeetingModel> GetPracticeMeetings()
        {
            return _practiceMeetings;
        }
    }
}
