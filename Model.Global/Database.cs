using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Model.Global.Models;

namespace Model.Global
{
    public class Database
    {
        public List<ToDo> todos { get; set; }

        public Database()
        {
            todos.Add(new ToDo() {Id = 1, Label = "Couse", Content = "Faire les course", DateCrea = DateTime.Now, ItsDone = true});
            todos.Add(new ToDo() {Id = 1, Label = "Etudier", Content = "Faire les exercice", DateCrea = DateTime.Now, ItsDone = false});
            todos.Add(new ToDo() {Id = 1, Label = "Nettoyer", Content = "Faire le nettoyage", DateCrea = DateTime.Now, ItsDone = true});
            todos.Add(new ToDo() {Id = 1, Label = "Jouer", Content = "Allumer la Play", DateCrea = DateTime.Now, ItsDone = false});
        }
    }
}