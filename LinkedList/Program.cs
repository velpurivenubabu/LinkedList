namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to linked list!");
            Console.WriteLine("Please Enter any one below Options\n1.Add data to the last\n2.Add data to the First\n3.Append Data");
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
                    customLinkedList1.Display();
                    break;
                case 3:
                    CustomLinkedList customLinkedList2 = new CustomLinkedList();
                    customLinkedList2.Append(30);
                    customLinkedList2.Append(70);
                    customLinkedList2.Append(56);
                    customLinkedList2.Display();
                    break;
            }
        }
    }
}