using System;
namespace PracticeMeeting.Models
{
    public class PracticeMeetingModel
    {
        public string Speaker { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
