using BlazorStateManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStateManagement.StateContainers
{
    public partial class ToDoState
    {
        public class Manager
        {
            private readonly ToDoState state;

            public Manager(ToDoState state)
            {
                this.state = state;
            }

            public void AddItem(ToDoItem item)
            {
                this.state.ToDoItems.Add(item);
                OnToDoItemAdded?.Invoke();
            }

            public void ToggleComplete(int index)
            {
                this.state.ToDoItems.ElementAt(index).IsComplete = !this.state.ToDoItems.ElementAt(index).IsComplete;
                OnIsCompleteChanged?.Invoke();
            }

            public event Action OnIsCompleteChanged;
            public event Action OnToDoItemAdded;
        }
    }
}
