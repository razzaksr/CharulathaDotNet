using System.Collections;
namespace Collect
{
    class DemoSorted{
        public void sortedOne(){
            SortedList sortedList=new SortedList();
            
            sortedList.Add(10.5,"Razak Moahmed");sortedList.Add(4.5,"Annamalai");
            sortedList.Add(3.4,"Manoj");sortedList.Add(9.2,"Rasheedha");

            //ICollection myKeys=sortedList.Keys;
            IList myKeys=sortedList.GetKeyList();

            foreach (var item in myKeys)
            {
                Console.WriteLine(item+" "+sortedList[item]);
            }

            Console.WriteLine("Find at index 2"+sortedList.GetByIndex(2));

            Console.WriteLine("Find Key by index "+sortedList.GetKey(3));

            Console.WriteLine("Find index of 4.5 "+sortedList.IndexOfKey(4.5));

        }
    }
}