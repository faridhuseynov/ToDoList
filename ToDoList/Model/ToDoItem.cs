using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    public class ToDoItem:ObservableObject
    {
        public int Id { get; set; }
        private string name;
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }
        private bool isDone;
        public bool IsDone
        {
            get => isDone;
            set => Set(ref isDone, value);
        }
    }
}
