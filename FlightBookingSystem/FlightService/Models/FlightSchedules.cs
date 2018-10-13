using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlightService.Models
{
    public class FlightSchedules : EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public override int Id { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public DateTime ArivalDateTime { get; set; }


        public int FlightId { get; set; }
        public FlightDetails FlightDetails { get; set; }


    }
}
