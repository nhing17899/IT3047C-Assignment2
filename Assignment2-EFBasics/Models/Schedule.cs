using System.ComponentModel.DataAnnotations;

namespace Assignment2_EFBasics.Models
{
    /*
        Model SCHEDULE
        Attributes: id, meetingDate, time, subject
    */
    public class Schedule
    {
        public int Id { get; set; }
        public string MeetingDate { get; set; }
        public TimeSpan Time { get; set; }
        public string Subject { get; set; }
    }
}