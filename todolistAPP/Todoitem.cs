using System;
using System.Collections.Generic;
using System.Text;

namespace todolistAPP
{
    public class todoitem
    {
        public string TodoText { get; set; }
        public bool complete { get; set; } //determine whether todo is complete
        public todoitem(string TodoText, bool complete)
        {
            this.TodoText = TodoText;
            this.complete = complete;
        }
    }
}
