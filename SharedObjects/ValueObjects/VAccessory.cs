using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SharedObjects.ValueObjects
{
    public class VAccessory
    {
        public int AccessoryId { get; set; }
        public string Accessory { get; set; }
        public string Description { get; set; }
        public byte? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedName { get; set; }
        public string CreatedEmail { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedName { get; set; }
        public string UpdatedEmail { get; set; }
    }
}
