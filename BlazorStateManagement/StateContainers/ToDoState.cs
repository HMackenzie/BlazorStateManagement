using BlazorStateManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorStateManagement.StateContainers
{
    public partial class ToDoState
    {
        public List<ToDoItem> ToDoItems { get; private set; } = new List<ToDoItem>();
    }
}
