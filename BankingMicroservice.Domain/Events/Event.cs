using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingMicroservice.Domain.Events
{
    public abstract class Event 
    {
        public DateTime TimeStamp { get; protected set; }

        protected Event()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
