using System;
using System.ComponentModel.DataAnnotations;
namespace WebApi13Oct2020
{
    public class Schedule
    {
        [Key]
        public int ID { get; set; }
        public string Week { get; set; }
        public DateTime GameDate { get; set; }
        public string AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public int AwayPoints { get; set; }
        public int HomePoints { get; set; }
        public int Attendance { get; set; }
    }
}
