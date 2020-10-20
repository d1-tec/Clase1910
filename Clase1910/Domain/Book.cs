using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Book : IRentable
    {
        public string Name { get; set; }

        public void AddRent(Rent rent)
        {
            throw new NotImplementedException();
        }

        public bool IsAvailableToRent(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
