using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp {
    public class Board {
        public List<Card> Todo = new List<Card>();
        public List<Card> InProgress = new List<Card>();
        public List<Card> Done = new List<Card>();
    }
}
