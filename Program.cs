namespace StackedLinkedList2026
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackLL s1 = new StackLL();


            s1.Push(5);
            s1.Push(6);
            s1.Push(6);
            s1.Push(8);
            s1.printAllNodes();
            Console.WriteLine();
            Console.WriteLine("pop");
            s1.Pop();
            s1.printAllNodes();

            Console.WriteLine("Peek");
            Console.WriteLine("The top of the stack: " + s1.Peek());


        }
    }
}