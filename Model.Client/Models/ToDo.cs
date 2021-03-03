using System;

namespace Model.Client.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Content { get; set; }
        public DateTime DateCrea { get; set; }
        public bool ItsDone { get; set; }
    }
}