using System;
using System.ComponentModel.DataAnnotations;
namespace WebApi13Oct2020
{
    public class Team
    {
        [Key]
        public int ID { get; set; }
        public string Abbrev { get; set; }
        public string Longname { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
    }
}
