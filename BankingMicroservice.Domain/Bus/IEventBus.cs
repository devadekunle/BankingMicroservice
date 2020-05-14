using BankingMicroservice.Domain.Commands;
using BankingMicroservice.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingMicroservice.Domain.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>;
    }
}
