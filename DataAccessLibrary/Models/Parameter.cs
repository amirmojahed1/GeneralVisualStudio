using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Parameter
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string GroupName { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string ValueControl { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string DisplayPriority { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
