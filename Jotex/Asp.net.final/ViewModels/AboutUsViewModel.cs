using Jotex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.ViewModels
{
    public class AboutUsViewModel
    {

        public IEnumerable<AboutUs> Abouts { get; set; }
        public AboutUs AboutUs { get; set; }
    }
}
