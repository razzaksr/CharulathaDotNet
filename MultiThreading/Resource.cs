namespace MyThread{
    class Factor{
        //"Jinja","Flutter","React native","Go lang","Vue","Angular","Java","DJango","Flask"
        string[] arr={"DJango","Flask","Jinja","Flutter","React native","Go lang","Vue","Angular","Java"};
        
        public void clock(int shift){
            String[] temp=new String[arr.Length];
            for(int index=0;index<arr.Length;index++){
                temp[(index+shift)%arr.Length]=arr[index];
            }
            foreach (var item in temp)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        
        public void display(){
            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }    
}