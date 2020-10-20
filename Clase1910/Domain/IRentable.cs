using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRentable
    {
        bool IsAvailableToRent(DateTime from, DateTime to);
        void Book(DateTime from, DateTime to);
    }
}
