using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public string SerailNumber { get; set; }
        public string BoxNumber { get; set; }
        public string AssemblyNumber { get; set; }
        public string Revision { get; set; }
        public string AccessoryList { get; set; }
        public string TestResult { get; set; }
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
