namespace EventTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        public int EventId { get; set; }

        [StringLength(50)]
        public string EventNavn { get; set; }

        public TimeSpan? EventTid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EventDato { get; set; }

        [StringLength(50)]
        public string EventAdresse { get; set; }

        public int? EventPostnummer { get; set; }
    }
}
