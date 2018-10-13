using System;
using System.Collections.Generic;

namespace BookingService.Model
{
    public interface IBookingRepository : IDisposable   
    {
        IEnumerable<Booking> GetAllBooking();
        Booking GetBookingById(int bookingId);
        int AddBooking(Booking bookingEntity);
        int UpdateBooking(Booking bookingEntity);
        void DeleteBooking(int bookingId);
    }
}
