using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class BAVViewModel : PaginationViewModel
    {
        public int Id { get; set; }
        public string Accessory { get; set; }
        public string Model { get; set; }
        public string Family { get; set; }
        public string Revision { get; set; }
        public string Description { get; set; }
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
