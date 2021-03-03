using Model.Client.Models;
using Model.Global.Repositories;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Model.Client.Mapper;
using Model.Client.Services;
namespace Model.Client.Services

{
    public class ToDoService
    {
        private ToDoRepository _repo;

        public ToDoService()
        {
            _repo = new ToDoRepository();
        }
        public ToDo Get(int id)
        {
            return _repo.Get(id).ToClient();
        }

        public IEnumerable<ToDo> Get()
        {
            return _repo.Get().Select(s => s.ToClient());
        }

        public int Insert(ToDo entity)
        {
            return _repo.Insert(entity.ToGlobal());
        }
        public bool Update(int id, ToDo entity)
        {
            return _repo.Update(id, entity.ToGlobal());
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
        
    }
}