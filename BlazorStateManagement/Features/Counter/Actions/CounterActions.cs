using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStateManagement.Features.Counter.Actions
{
    public class IncrementCountAction : IRequest<CounterState>
    {
        public int Amount { get; set; }
    }
}
