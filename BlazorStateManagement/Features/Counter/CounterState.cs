using BlazorState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStateManagement.Features.Counter
{
    public partial class CounterState : State<CounterState>
    {
        public int Count { get; private set; }

        protected override void Initialize() => Count = 3;
    }
}
