﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime? CheckingDate { get; set; }
        public DateTime? CheckoutDate { get; set; }
        public DateTime? BkgDate { get; set; }
        public double Amount { get; set; }

    }
}