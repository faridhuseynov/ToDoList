using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model;

namespace ToDoList
{
    public class ToDoRepository
    {
       public void Add(ToDoItem item)
        {
            using (var db = new ToDoContext())
            {
                db.ToDoItems.Add(item);
                db.SaveChanges();
            }
        }

        public void Edit(int Id)
        {
            using (var db=new ToDoContext())
            {
                var item = db.ToDoItems.Where(x => x.Id == Id).FirstOrDefault();
                item.IsDone = !item.IsDone;
                db.SaveChanges();
            }
        }

        public void Remove(int Id)
        {
            using (var db = new ToDoContext())
            {
                var item = db.ToDoItems.Where(x => x.Id == Id).FirstOrDefault();
                db.ToDoItems.Remove(item);  
                db.SaveChanges();
            }
        }

        public IEnumerable<ToDoItem>List()
        {
            using(var db=new ToDoContext())
            {
                return db.ToDoItems.ToList();
            }
        }
    }
}
