using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindagoWebApplication.Models.Events
{
    public class Event
    {
        [Key]
        [ForeignKey("EventID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        [StringLength(3)]
        public string Country { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ForegroundColor { get; set; }
        public string BackgroundColor { get; set; }
        public int? MaxCapacity { get; set; } //This will only be populated if we are integrated with event websites
        public int? TicketsSold { get; set; }
        public bool isActive { get; set; }
    }
}
