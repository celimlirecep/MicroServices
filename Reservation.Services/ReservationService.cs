using Reservation.Infrastructure;
using Reservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBkgNumber(int bkgNumber)
        {
            return new ReservationDTO()
            {
                Id=(new Random()).Next(100),
                Amount= (new Random()).Next(1000),
                BkgDate=DateTime.Now,
                CheckingDate=DateTime.Now.Date.AddDays(30),
                CheckoutDate=DateTime.Now.Date.AddDays(37),
                BkgNumber=bkgNumber
            };
        }
    }
}
