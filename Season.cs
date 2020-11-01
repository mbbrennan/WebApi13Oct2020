using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi13Oct2020
{
    public class Season
    {
        [Key]
        public int ID { get; set; }
        public int SeasonID { get; set; }
        public string SeasonName { get; set; }
    }
}
