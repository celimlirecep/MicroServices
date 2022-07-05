using Reservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Infrastructure
{
    public interface IReservationService
    {
        ReservationDTO GetReservationByBkgNumber(int bkgNumber);
    }
}
