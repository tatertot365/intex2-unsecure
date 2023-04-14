using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModels
{
    public class PageInfo
    {
        public int totalNumBurials { get; set; }
        public int burialsPerPage { get; set; }
        public int currentPage { get; set; }
        public int numPages => (int)Math.Ceiling((double)totalNumBurials / burialsPerPage);
    }
}
