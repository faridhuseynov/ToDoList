using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    class ToDoContext:DbContext
    {
        public ToDoContext() : base("DefaultConnection") { }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
