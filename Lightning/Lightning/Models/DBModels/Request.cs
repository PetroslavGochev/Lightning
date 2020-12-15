using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lightning.Models.DBModels
{
    public class Request
    {
        public int Id { get; set; }
        public LightningUser LightningUser { get; set; }
        public string Status { get; set; }
        public string Content { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Package { get; set; }
        public string Address { get; set; }
    }
}
