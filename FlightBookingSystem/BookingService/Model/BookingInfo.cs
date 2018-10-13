namespace BookingService.Model
{

    public class BookingInfo
    {
        //[Key]
        //[ForeignKey("Booking")]
        public int BookingId { get; set; }

        //[Key]
        //[ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public int ScheduledId { get; set; }

        //[Key]
        //[ForeignKey("Flight")]
        public int FlightId { get; set; }

        public int PaymentId { get; set; }

        public bool BookingState { get; set; }

    }
}
