namespace Overloading{
    class CompileTime{

        public void arrange(String[] arr, String user, int end ,int start=0){
            if(end>start){
                int mid=start+(end-start)/2;
                Console.WriteLine(arr[mid]+" "+arr[start]+" "+arr[end]);
                if(arr[mid].CompareTo(user)==0){
                    Console.WriteLine(user+" found @ "+mid);return;
                }
                else if(arr[mid].CompareTo(user)>0){
                    arrange(arr,user,mid-1,start);
                }
                else{
                    arrange(arr,user,end,mid+1);
                }
            }
            else{
                Console.WriteLine(user+" hasn't found anywhere");
            }
        }

        public void arrange(String[] arr){
            for (int current = 1; current < arr.Length; current++)
            {
                String holded=arr[current];
                int previous=current-1;
                while(previous>=0&&arr[previous].CompareTo(holded)>0){
                    arr[previous+1]=arr[previous];
                    arr[previous]=holded;
                    previous--;
                }
            }
        }

        public void showArray(String[] arr){
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }

        public void filter(String[] alpha, String cosmo, out int position){
            position=-1;
            for (int index = 0; index < alpha.Length; index++)
            {
                if(alpha[index].CompareTo(cosmo)==0){
                    position=index;
                    return;
                }
            }
        }

        public void filter(String sub,String[] obj){
            Console.WriteLine("Here are the matches for "+sub);
            foreach (String item in obj)
            {
                if(item.CompareTo(sub)>0){
                    Console.WriteLine(item);
                }
            }
        }

        public void filter(String[] obj, String sub){
            Console.WriteLine("Here are the matches for "+sub);
            foreach (String item in obj)
            {
                if(item.CompareTo(sub)<0){
                    Console.WriteLine(item);
                }
            }
        }

        public void filter(String[] obj){
            String min=obj[0];
            String max=obj[0];

            foreach (String item in obj)
            {
                if(item.CompareTo(min)<0){
                    min=item;
                }
                if(item.CompareTo(max)>0){
                    max=item;
                }
            }

            Console.WriteLine("Maximum is "+max+" and minimum is "+min);
        }
    }
}