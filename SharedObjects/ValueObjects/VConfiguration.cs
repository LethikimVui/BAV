using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SharedObjects.ValueObjects
{
    public class VConfiguration
    {
        public Int64 rc { get; set; }
        public int ConfigId { get; set; }
        public string Model { get; set; }
        public string Revision { get; set; }
        public string Family { get; set; }
        public string Description { get; set; }
        public string Accessory { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedName { get; set; }
        public string CreatedEmail { get; set; }
    }
}
