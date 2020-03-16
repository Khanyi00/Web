using System;

namespace WindowsFormsApp1
{
   public class Timeslots
    {
        public int TimeslotId { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public float HoursCaptured { get; set; }
    }
}
