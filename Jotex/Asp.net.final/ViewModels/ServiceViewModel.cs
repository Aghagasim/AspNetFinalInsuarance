using Jotex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.ViewModels
{
    public class ServiceViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public Service Service { get; set; }
    }
}
