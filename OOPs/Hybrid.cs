namespace Heritance
{
    // hybrid
    class Backend:Warehouse{
        int[] arr;
        public int getArrSize(){
            return arr.Length;
        }
        private Backend(){
            arr=new int[10];
        }
        private Backend(int size){
            arr=new int[size];
        }
        private static Backend backend=new Backend();
        public static Backend GetBackend(){
            return backend;
        }
        public static Backend GetBackend(int size){
            backend.arr=new int[size];
            return backend;
        }
        public void insert(int data){
            for(int index=0;index<arr.Length;index++){
                if(arr[index]==0){
                    arr[index]=data;
                    Console.WriteLine(data+" has set @ "+index);
                    return;
                }
            }
            Console.WriteLine(data+" couldn't set due to insuffcient space");
        }
    }
}