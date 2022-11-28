using System;

namespace CarRentalManagement1.Shared.Domain
{
    public class Booking: BaseDomainModel
    {
        public DateTime Dateout { get; set; }
        public DateTime DateIn { get; set; }

        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }
        
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }

    }
