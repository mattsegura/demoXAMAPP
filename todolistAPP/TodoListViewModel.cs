using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace todolistAPP
{
    public class TodoListViewModel
    {
        public ObservableCollection<todoitem> TodoItems { get; set; } 
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<todoitem>();
            TodoItems.Add(new todoitem("todo 1", false));
            TodoItems.Add(new todoitem("todo 2", false));


        }
    }
}
