using System.IO;
namespace Files
{
    class DemoTextWriteRead{
        static FileInfo fileInfo=new FileInfo("D:/Course backups/Dotnet/Charulatha/thirdFile.doc");
        public static void writeSome(){
            TextWriter writter=fileInfo.CreateText();// write mode
            for(int times=1;times<=5;times++){
                Console.WriteLine("Enter the content to write ");
                writter.WriteLine(Console.ReadLine());
            }
            writter.Close();
            Console.WriteLine(fileInfo.Name+" has written");
        }
        public static void readSome(){
            TextReader reader=fileInfo.OpenText();
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
    }
}