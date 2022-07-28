using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp {
    public class Card {
        private string title;
        private string description;
        private int userId;
        private int size;
   

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public int UserId { get => userId; set => userId = value; }
        public int Size { get => size; set => size = value; }


        public Card() { }
        public Card(string title, string description, int userId, int size) {
            this.Title = title;
            this.Description = description;
            this.UserId = userId;
            this.Size = size;
        }
    }
}
