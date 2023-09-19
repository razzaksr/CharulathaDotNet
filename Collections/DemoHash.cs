using System.Collections;
namespace Collect
{
    class DemoHash{
        public void table(){
            Hashtable contacts=new Hashtable();

            contacts.Add("Rasheedha",87656789876L);
            contacts.Add("Razak",98765677634L);
            contacts.Add("Rajiya",6567867893L);
            contacts.Add("Sabari",98765677634L);

            ICollection myKeys=contacts.Keys;

            foreach (var item in myKeys)
            {
                Console.WriteLine(item+" "+contacts[item]);
            }

            contacts.Remove("Sabari");

            Console.WriteLine("Is Sabari exists "+contacts.ContainsKey("Sabari"));
            Console.WriteLine("Is 98765677634L exists "+contacts.ContainsValue(98765677634L));

            
        }
    }
}