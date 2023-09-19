using System.IO;
namespace Files
{
    class DemoBinaryWriteRead{
        public static void writeSome(){
            using(BinaryWriter writer=new BinaryWriter(File.Open("myfiles/fourthFile.doc",FileMode.OpenOrCreate))){
                
                string alphabet="Mockito JUnit";
                int version=12;
                double experience=5.6;

                writer.Write(alphabet);
                writer.Write(version);
                writer.Write(experience);

                Console.WriteLine("Content has written as Binary");
            }
        }
        public static void readSome(){
            using(BinaryReader reader=new BinaryReader(File.Open("myfiles/fourthFile.doc",FileMode.Open))){
                Console.WriteLine(reader.ReadString());
                Console.WriteLine(reader.ReadInt32());
                Console.WriteLine(reader.ReadDouble());
            }
        }
    }
}