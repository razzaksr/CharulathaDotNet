using System.Collections;
namespace Collect
{
    class DemoQueue{
        // Enqueue, Dequeue, Contains, ToArray
        public void demoFifo(){
            Queue<String> myQueue=new Queue<String>();

            myQueue.Enqueue("Spring Boot");myQueue.Enqueue("Flask");
            myQueue.Enqueue("Express");myQueue.Enqueue("DJango");
            myQueue.Enqueue("Thymeleaf");myQueue.Enqueue("React");
            myQueue.Enqueue("Jinja");myQueue.Enqueue("Angular");

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("To be deleted is "+myQueue.Dequeue());

            Console.WriteLine("Check for Spring Boot "+myQueue.Contains("Spring Boot"));

            myQueue.Clear();

            Console.WriteLine(myQueue.Count());
        }
    }
}