using BlazorState;
using BlazorStateManagement.Features.Counter.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorStateManagement.Features.Counter
{
    public partial class CounterState
    {
        public class IncrementCountHandler : RequestHandler<IncrementCountAction, CounterState>
        {
            public IncrementCountHandler(IStore aStore) : base(aStore) { }

            CounterState CounterState => Store.GetState<CounterState>();

            public override Task<CounterState> Handle(IncrementCountAction aIncrementCountAction, CancellationToken aCancellationToken)
            {
                CounterState.Count = CounterState.Count + aIncrementCountAction.Amount;
                return Task.FromResult(CounterState);
            }
        }

    }
}
