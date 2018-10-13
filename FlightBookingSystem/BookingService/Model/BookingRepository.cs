using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookingService.Model
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookingContext _context = new BookingContext(options);
        //private readonly BookingContext _context// = new BookingContext(options);
        private static readonly DbContextOptions options;

        public BookingRepository(BookingContext context)
        {
            _context = context;
        }

        #region IBookingRepository Interface Implementation

        public IEnumerable<Booking> GetAllBooking()
        {
            return _context.Bookings.ToList();
        }
        public Booking GetBookingeById(int studentId)
        {
            return _context.Bookings.Find(studentId);
        }

        public int AddBooking(Booking employeeEntity)

        {
            int result = -1;

            if (employeeEntity != null)
            {
                _context.Bookings.Add(employeeEntity);
                _context.SaveChanges();
                result = employeeEntity.BookingId;
            }
            return result;

        }
        public int UpdateBooking(Booking employeeEntity)
        {
            int result = -1;

            if (employeeEntity != null)
            {
                _context.Entry(employeeEntity).State = EntityState.Modified;
                _context.SaveChanges();
                result = employeeEntity.BookingId;
            }
            return result;
        }
        public void DeleteEmployee(int employeeId)
        {
            Booking employeeEntity = _context.Bookings.Find(employeeId);
            _context.Bookings.Remove(employeeEntity);
            _context.SaveChanges();

        }

        #endregion

        #region IDisposable Interface Implementation

        private bool disposed = false;
        private bool disposing = false;

        public void Dispose()
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public Booking GetBookingById(int bookingId)
        {
            throw new NotImplementedException();
        }

        public void DeleteBooking(int bookingId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
