namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to linked list!");
            Console.WriteLine("Please Enter any one below Options");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    CustomLinkedList customLinkedList = new CustomLinkedList();
                    customLinkedList.AddLast(56);
                    customLinkedList.AddLast(30);
                    customLinkedList.AddLast(70);
                    break;

                case 2:
                    CustomLinkedList customLinkedList1 = new CustomLinkedList();
                    customLinkedList1.AddFirst(70);
                    customLinkedList1.AddFirst(30);
                    customLinkedList1.AddFirst(56);
                    break;
            }
        }
    }
}