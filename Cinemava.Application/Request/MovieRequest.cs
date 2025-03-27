using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemava.Application.Request
{
    public class MovieRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime ReleasedDate { get; set; }
    }
}
