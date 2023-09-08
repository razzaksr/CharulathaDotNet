delegate int search(int role);
delegate T find<T>(T apex);
namespace Del{
    class Perform{
        int[] arr={98,23,45,456,23,56,78,34,78,11,9,4,12};
        public int linear(int data){
            for(int index=0;index<arr.Length;index++){
                if(arr[index]==data)
                    return index;
            }
            return -1;
        }

        public void sorting(){
            for(int select=0;select<arr.Length;select++){
                for(int compare=select+1;compare<arr.Length;compare++){
                    if(arr[select]>arr[compare])
                    {
                        arr[select]*=arr[compare];
                        arr[compare]=arr[select]/arr[compare];
                        arr[select]/=arr[compare];
                    }
                }
            }
        }

        public int binary(int data){
            sorting();
            int current=0,end=arr.Length-1;
            while(current<=end){
                int midIndex=current+(end-current)/2;
                if(arr[midIndex]==data)
                    return midIndex;
                else if(arr[midIndex]>data)
                    end=midIndex-1;
                else
                    current=midIndex+1;
            }
            return -1;
        }
    }
}