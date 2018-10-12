using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightService.Models
{
    public class FlightDetails : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public override int Id { get; set; }

        public string FlightName { get; set; }

        public string FlightNumber { get; set; }

        public int FirstClassSeat { get; set; }

        public int BusinessClassSeat { get; set; }

        public int EconomySeat { get; set; }

        public int FirstClassFare { get; set; }

        public int BusinessClassFare { get; set; }

        public int EconomyFare { get; set; }

        //public virtual ICollection<FlightSchedules> FlightSchedules { get; set; }
    }
}
