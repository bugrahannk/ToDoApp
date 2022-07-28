using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp {
    public class Person {
        private int id;


      //  public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }


        public Person() { }
        public Person( int id) {
            this.id = 5;
        }
    }
}

