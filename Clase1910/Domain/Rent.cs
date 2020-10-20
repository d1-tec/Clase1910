using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rent
    {
        public IRentable Rentable { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
