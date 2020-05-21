using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class CaseStudies:Base
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
    }
}
