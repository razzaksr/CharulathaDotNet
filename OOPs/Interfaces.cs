namespace Heritance{
    // class UPI:Netbanking,BharatPay{

    // }

    interface Fetch{
        public Object readAt(int index);
        public void listAll();
    }

    interface Impact{
        public void insert(Object data);
        public void update(object data, int position);
        public int deletion(object data);
    }

    // multiple inheritance
    class Warehouse:Impact, Fetch{
        Object[] arr;
        public Warehouse(){}
        public Warehouse(int size){
            arr=new Object[size];
        }
        public int deletion(object data){
            for(int index=0;index<arr.Length;index++){
                if(data.Equals(arr[index])){
                    arr[index]=null;
                    return index;
                }
            }
            return -1;
        }
        public void update(object data, int position){
            if(position<arr.Length&&position>-1){
                object old=arr[position];
                arr[position]=data;
                Console.WriteLine(data+" has replaced"+old+" @ "+position);
            }
            else{
                Console.WriteLine("invalid position "+position);
            }
        }
        public void insert(object data){
            for(int index=0;index<arr.Length;index++){
                if(arr[index]==null){
                    arr[index]=data;
                    Console.WriteLine(data+" has set @ "+index);
                    return;
                }
            }
            Console.WriteLine(data+" couldn't set due to insuffcient space");
        }
        public object readAt(int index){
            if(index<arr.Length&&index>-1){
                return arr[index];
            }
            else{
                return null;
            }
        }
        public void listAll(){
            foreach (var item in arr)
            {
                if(item!=null)
                    Console.WriteLine(item);
            }
        }
    }

    interface SampleFace{
        // data members are constant
        const String framework="DJango";

        void modify();// abstract function
    }

    // single inheritance
    class MyFaceInter:SampleFace{
        // non abtsract
        public void myOwn(){
            Console.WriteLine("Derived's own method");
        }
        // overriding
        public void modify(){
            Console.WriteLine("Overriden from SampleFace");
        }
    }

}