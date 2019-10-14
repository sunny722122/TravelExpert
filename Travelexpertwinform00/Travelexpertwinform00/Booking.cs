using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelexpertwinform00
{
    class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingNo { get; set; }
        public int TravelerCount { get; set; }
        public int CustomerId { get; set; }
        public string TripTypeId { get; set; }
        public int PackageId { get; set; }
    }
}
