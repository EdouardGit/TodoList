using System;
using System.Collections.Generic;
using System.Text;
using G = Model.Global.Models;
using C = Model.Client.Models;
namespace Model.Client.Mapper
{
    public static class Mapper
    {
        public static C.ToDo ToClient(this G.ToDo entity)
        {
            if (entity == null) return null;
            return new C.ToDo()
            {
                Id= entity.Id,
                Label = entity.Label,
                Content = entity.Content,
                DateCrea = entity.DateCrea,
                ItsDone = entity.ItsDone
            };
        }

        public static G.ToDo ToGlobal(this C.ToDo entity)
        {
            if (entity == null) return null;
            return new G.ToDo()
            {
                Id = entity.Id,
                Label = entity.Label,
                Content = entity.Content,
                DateCrea = entity.DateCrea,
                ItsDone = entity.ItsDone
            };
        }
    }
}