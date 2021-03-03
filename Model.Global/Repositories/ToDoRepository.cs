using System.Collections.Generic;
using System.Linq;
using Model.Global.Models;

namespace Model.Global.Repositories
{
    public class ToDoRepository
    {
        public ToDo Get(int id)
        {
            return DBContext.DB.todos.Where(t => t.Id == id).SingleOrDefault();
        }

        public IEnumerable<ToDo> Get()
        {
            return DBContext.DB.todos;
        } 

        public int Insert(ToDo entity)
        {
            int maxId = DBContext.DB.todos.Max(t => t.Id);
            maxId += 1;
            entity.Id = maxId;
            DBContext.DB.todos.Add(entity);
            return entity.Id;
        }

        public bool Update(int id, ToDo entity)
        {
            if (DBContext.DB.todos.Select(t => t.Id).Contains(id))
            {
                ToDo oldData = this.Get(id);
                oldData.Label = entity.Label;
                oldData.Content = entity.Content;
                oldData.DateCrea = entity.DateCrea;
                oldData.ItsDone = entity.ItsDone;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            if (DBContext.DB.todos.Select(t => t.Id).Contains(id))
            {
                ToDo oldData = this.Get(id);
                DBContext.DB.todos.Remove(oldData);
                return true;               
            }
            return false;
        }
    }
}