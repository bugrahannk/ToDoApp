using ToDoApp;

Operation operation = new Operation();
/*operation.initCard();
operation.AddCard();
operation.ListCard();
*/
operation.initCard();
while (true) {
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin: ");
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1) Board Listelemek");
    Console.WriteLine("(2) Board'a Kart Eklemek");
    Console.WriteLine("(3) Board'dan Kart Silmek");
    Console.WriteLine("(4) Kart Taşımak");
    int secim = Convert.ToInt32(Console.ReadLine());
    
    switch (secim) {
        case 1:
            Console.Clear();
            operation.ListCard();
            break;
        case 2:
            Console.Clear();
            operation.AddCard();
            break;
        case 3:
            Console.Clear();
            operation.RemoveCard();
            break;
        case 4:
            Console.Clear();
            operation.MoveCard();
            break;
        default:
            break;
    }
}