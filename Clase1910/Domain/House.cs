using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class House : IRentable
    {
        private List<Rent> rents;

        public string Name { get; set; }

        public House()
        {
            rents = new List<Rent>();
        }

        public void Book(DateTime from, DateTime to)
        {
            this.rents.Add(new Rent() { Rentable = this, From = from, To = to });
        }

        public bool IsAvailableToRent(DateTime from, DateTime to)
        {
            return this.rents.Any(rent => to > rent.From);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
