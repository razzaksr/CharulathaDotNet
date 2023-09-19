using System.IO;
using System.Text;
namespace Files
{
    class DemoFileStreams{
        static FileStream fileStream=null;
        public static void create(){
            fileStream=new FileStream("myfiles/firstFile.txt",FileMode.OpenOrCreate);
            fileStream.Close();
            Console.WriteLine(fileStream.Name+" has created");
        }
        public static void writeSome(){
            fileStream=new FileStream("myfiles/firstFile.txt",FileMode.OpenOrCreate);

            Console.WriteLine("Enter some data ");
            string myData=Console.ReadLine();

            byte[] arr=Encoding.ASCII.GetBytes(myData);

            fileStream.Write(arr);

            fileStream.Close();

            Console.WriteLine("Some Content has written in a file");
        }
        public static void appendSome(){
            fileStream=new FileStream("myfiles/firstFile.txt",FileMode.Append);

            Console.WriteLine("Enter some data ");
            string myData=Console.ReadLine();

            byte[] arr=Encoding.ASCII.GetBytes(myData);

            fileStream.Write(arr);

            fileStream.Close();

            Console.WriteLine("Some Content has appended in a file");
        }
        public static void readSome(){
            fileStream=new FileStream("myfiles/firstFile.txt",FileMode.OpenOrCreate);

            byte[] arr=new byte[100];

            fileStream.Read(arr);

            fileStream.Close();

            foreach (var item in arr)
            {
                Console.Write((char)item);
            }
            Console.WriteLine();
        }
    }
}