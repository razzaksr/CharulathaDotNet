namespace Handle{
    class Finite{
        String[] arr={"VS Code","Flutter","React-Native","Vite.js","Vue.js","Material","Bootstrap"};
        static int count=0;
        public void limited(){
            count++;
            try{
                Console.WriteLine("Select technology by index ");
                int index=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr[index]+" was choosen by you");
            }
            catch(FormatException format){
                Console.WriteLine("Only numbers are required ");
                int index=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr[index]+" was choosen by you");
            }
            catch(IndexOutOfRangeException inOut){
                Console.WriteLine("Index should be within "+arr.Length);
                if(count<3)
                    limited();
                else
                    Console.WriteLine("Maximum attempts obtained");
            }
        }
        // nested
        public void nested(){
            count++;
            try{
                Console.WriteLine("Select technology by index ");
                int index=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr[index]+" was choosen by you");
            }
            catch(FormatException format){
                try{
                    Console.WriteLine("Only numbers are required ");
                    int index=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(arr[index]+" was choosen by you");
                }
                catch(IndexOutOfRangeException inOut){
                    Console.WriteLine("Index should be within "+arr.Length);
                    int index=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(arr[index]+" was choosen by you");
                }
            }
            catch(IndexOutOfRangeException inOut){
                Console.WriteLine("Index should be within "+arr.Length);
                int index=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr[index]+" was choosen by you");
            }
        }
    }
}