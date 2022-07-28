using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp {
    public class Operation {
        
        Board board = new Board(); 
        Person person = new Person();
        
        public void initCard() {
            board.Todo.Add(new Card("Alısveris", "Domates Al", 1, 5));
            board.InProgress.Add(new Card("Alısveris", "Domates Al", 2, 6));
            board.Done.Add(new Card("Alısveris", "Domates Al", 3, 7));
            board.Done.Add(new Card("Alısveris", "Domates Al", 4, 8));
        }


        public void ListCard() {
            Console.WriteLine(" ");
            Console.WriteLine("TO-DO");
            Console.WriteLine("************");
            foreach (var item in board.Todo) {
                Console.WriteLine("Title: " + item.Title);
                Console.WriteLine("Description: " + item.Description);
                Console.WriteLine("Person: " + item.UserId);
                Console.WriteLine("Size: " + item.Size.ToString());
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }

            Console.WriteLine("IN-PROGRESS");
            Console.WriteLine("************");
            foreach (var item in board.InProgress) {
                Console.WriteLine("Title: " + item.Title);
                Console.WriteLine("Description: " + item.Description);
                Console.WriteLine("Person: " + item.UserId);
                Console.WriteLine("Size: " + item.Size.ToString());
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }

            Console.WriteLine("DONE");
            Console.WriteLine("************");
            foreach (var item in board.Done) {
                Console.WriteLine("Title: " + item.Title);
                Console.WriteLine("Description: " + item.Description);
                Console.WriteLine("Person: " + item.UserId);
                Console.WriteLine("Size: " + item.Size.ToString());
                Console.WriteLine(" ");
            }
        }

        public void AddCard() {
            Card card = new Card();
            Person person = new Person();
            person.Id = 5;

            Console.WriteLine("Title: ");
            card.Title = Console.ReadLine();

            Console.WriteLine("Description: ");
            card.Description = Console.ReadLine();

            Console.WriteLine("Person Id: ");
            card.UserId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Size: ");
            card.Size = Convert.ToInt32(Console.ReadLine());

            board.Todo.Add(card);
        }

        public void RemoveCard() {
            string _title;
            Console.WriteLine("Silmek istediğiniz kartın title'ı: ");
            _title = Console.ReadLine();
            bool isThere = false;

            foreach (var item in board.Todo.ToList()) {
                if(item.Title == _title) {
                    board.Todo.Remove(item);
                    isThere = true;
                }
            }

            foreach (var item in board.InProgress.ToList()) {
                if (item.Title == _title) {
                    board.InProgress.Remove(item);
                    isThere = true;
                }
            }

            foreach (var item in board.Done.ToList()) {
                if (item.Title == _title) {
                    board.Done.Remove(item);
                    isThere = true;
                }
            }

            if(isThere == false) {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için : (2)");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 2)
                    RemoveCard();
            }
        }

        public void MoveCard() {
            Console.Write("Taşımak istediğiniz kartın title'ı: ");
            string _title = Console.ReadLine();

            Console.WriteLine("Taşımak istediğiniz yer: ");
            Console.WriteLine("(1) TO-Do ");
            Console.WriteLine("(2) IN-PROGRESS: ");
            Console.WriteLine("(3) DONE");
            int _choice= Convert.ToInt32(Console.ReadLine());

            foreach (var item in board.Todo.ToList()) {
                if(_title == item.Title) {
                    switch (_choice) {
                        case 1:
                            board.Todo.Add(item);
                            break;
                        case 2:
                            board.InProgress.Add(item);
                            break;
                        case 3:
                            board.Done.Add(item);
                            break;
                    }
                    
                    board.Todo.Remove(item);
                }
            }

            foreach (var item in board.InProgress.ToList()) {
                if (_title == item.Title) {
                    switch (_choice) {
                        case 1:
                            board.Todo.Add(item);
                            break;
                        case 2:
                            board.InProgress.Add(item);
                            break;
                        case 3:
                            board.Done.Add(item);
                            break;
                    }

                    board.InProgress.Remove(item);
                }
            }

            foreach (var item in board.Done.ToList()) {
                if (_title == item.Title) {
                    switch (_choice) {
                        case 1:
                            board.Todo.Add(item);
                            break;
                        case 2:
                            board.InProgress.Add(item);
                            break;
                        case 3:
                            board.Done.Add(item);
                            break;
                    }

                    board.Done.Remove(item);
                }
            }
        }
    }
}
