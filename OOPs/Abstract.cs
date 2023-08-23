namespace Heritance{
    abstract class Component{
        public String[] arr={"Cypress","ES6 Lint","Redux","Express","Vue","React"};
        public void traverse(){
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public abstract void binary(String data,int start,int end);
    }

    class Mark : Component
    {
        public override void binary(string data, int start, int end)
        {
            if(start<=end){
                int mid=start+(end-start)/2;
                if(arr[mid].CompareTo(data)==0)
                    Console.WriteLine(mid+" is index where "+data+" has found");
                else if(arr[mid].CompareTo(data)>0)
                    binary(data,start,mid-1);
                else
                    binary(data,mid+1,end);
            }
            else
                Console.WriteLine(data+" hasn't found anywhere");
        }
    }
}