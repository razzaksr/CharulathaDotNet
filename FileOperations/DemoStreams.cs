using System.IO;
namespace Files
{
    class DemoStreams{
        static FileStream fileStream=null;
        public static void writting(){
            fileStream=new FileStream("myfiles/secondFile.doc",FileMode.OpenOrCreate);
            StreamWriter writter=new StreamWriter(fileStream);

            Console.WriteLine("Enter some data ");
            string myData=Console.ReadLine();
            writter.WriteLine(myData);

            writter.Close();
            fileStream.Close();

            Console.WriteLine(fileStream.Name+" has written with some content");
        }
        public static void reading(){
            fileStream=new FileStream("myfiles/secondFile.doc",FileMode.OpenOrCreate);
            StreamReader reader=new StreamReader(fileStream);
            string alpha="";
            while((alpha=reader.ReadLine())!=null){
                Console.WriteLine(alpha);
            }

            reader.Close();
        }
    }
}