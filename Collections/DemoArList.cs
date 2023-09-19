using System.Collections;
using System.Linq;
namespace Collect{
    class DemoArrayList{

        class Product{
            public string Name{set;get;}
            public string client{set;get;}
            public int week{set;get;}
            public double budget{set;get;}

            public override string ToString(){
                return "Product Details are "+Name+" client "+client+" Duration in weeks "+week+" and Budget is "+budget+"\n";
            }
        }

        public void userDefined(){
            List<Product> products=new List<Product>();

            products.Add(new Product{Name="IRCTC",client="Indian Railways",week=100,budget=4.5});
            products.Add(new Product{Name="Passport Seva",client="Ministry of Foriegn Affairs",week=87,budget=8.2});
            products.Add(new Product{Name="IncomeTaxFiling",client="Ministry of Finance",week=200,budget=18.5});
            products.Add(new Product{Name="uidai",client="Ministry of Defence",week=150,budget=9.2});

            var hai=from pro in products select pro;

            // foreach (var item in hai)
            // {
            //     Console.WriteLine(item);
            // }

            var say=products.Where(pro=>pro.budget<10.0).OrderBy(pro=>pro.week);
            foreach (var item in say)
            {
                Console.WriteLine(item);
            }
            // var say=products.FirstOrDefault(pro=>pro.budget<2.0);
            // Console.WriteLine(say);
            

        }

        // add, insert(index,v), index, removeAt,remove(object), reverse, sort, Capacity
        public void crudl(){
            ArrayList listObject=new ArrayList();
            
            listObject.Add("Razak Mohamed");listObject.Add(34);
            listObject.Add(false);listObject.Add(7.8);

            foreach (var item in listObject)
            {
                Console.WriteLine(item);
            }

            listObject.Insert(2,45.6);

            Console.WriteLine(listObject.Contains(false));

            Console.WriteLine(listObject.IndexOf(false));

            listObject.Remove(false);

            listObject.RemoveAt(3);

            //listObject.Sort();
            listObject.Reverse();
            // from VAR in Source select VAR
            // var hai=from lst in listObject select lst;

            foreach (var item in listObject)
            {
                Console.WriteLine(item);
            }

        }
    }
}