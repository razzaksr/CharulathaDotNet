using System.Collections;
using System.Linq;
namespace Collect
{
    class StackDemo{
        public void demoLiFo(){
            Stack<double> myStack=new Stack<double>();

            myStack.Push(4.5);myStack.Push(9.1);myStack.Push(45.2);
            myStack.Push(76.4);myStack.Push(11.4);
            myStack.Push(6.7);myStack.Push(11.4);myStack.Push(31.3);

            var show=from stk in myStack select stk;

            foreach (var item in show)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Popped Object is "+myStack.Pop());

            Console.WriteLine("Whether 31.3 exists: "+myStack.Contains(31.3));

            Console.WriteLine("Top of the Stack is "+myStack.Peek());

            double[] myArray=myStack.ToArray();

            var arr=from my in myArray select my;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            myStack.Clear();

            show=from stk in myStack select stk;
            Console.WriteLine("Listing after clear");
            foreach (var item in show)
            {
                Console.WriteLine(item);
            }           

        }
    }
}