namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to linked list!");
            Console.WriteLine("Please Enter any one below Options\n1.Add data to the last\n2.Add data to the First\n3.Append Data");
            int option=Convert.ToInt32(Console.ReadLine());
            CustomLinkedList customLinkedList = new CustomLinkedList();
            switch (option)
            {
                case 1:
                   
                    customLinkedList.AddLast(56);
                    customLinkedList.AddLast(30);
                    customLinkedList.AddLast(70);
                    break;

                case 2:
                    //CustomLinkedList customLinkedList = new CustomLinkedList();
                    customLinkedList.AddFirst(70);
                    customLinkedList.AddFirst(30);
                    customLinkedList.AddFirst(56);
                    customLinkedList.Display();
                    break;
                case 3:
                   
                    customLinkedList.Append(30);
                    customLinkedList.Append(70);
                    customLinkedList.Append(56);
                    customLinkedList.Display();
                    break;
            }
        }
    }
}