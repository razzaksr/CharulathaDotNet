using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Files
{
    [Serializable]
    class Bike{
        public string model{set;get;}
        public int year{set;get;}
        public double price{set;get;}

        public override string ToString(){
            return "Bike Details are Model "+model+" Year of MAnufacture "+year+" price is "+price+"\n";
        }
    }

    class DemoSerialization{
        static FileStream fileStream=new FileStream("myfiles/fifthFile.doc",FileMode.OpenOrCreate);
        static BinaryFormatter binaryFormatter=new BinaryFormatter();

        public static void serialize(){
            Bike bike=new Bike(){model="Avenger220",year=2016,price=109000.35};
            binaryFormatter.Serialize(fileStream,bike);
            Console.WriteLine("Object has written");
        }

        public static void deserialize(){
            Bike temp = (Bike) binaryFormatter.Deserialize(fileStream);
            Console.WriteLine(temp);
        }
    }
}