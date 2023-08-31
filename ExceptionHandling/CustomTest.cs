namespace Handle
{
    class DemostrateCustom{
        static String[] arr={"VS Code","Flutter","React-Native","Vite.js","Vue.js","Material","Bootstrap"};
        private static void show(){
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void authenticate(String userName,String passCode){
            try{
                if(userName.Equals("Charu")&&passCode.Equals("sonamca")){
                    show();
                }
                else{
                    throw new CharulathaException();   
                }
            }
            catch(CharulathaException except){
                Console.WriteLine(except);
                Console.WriteLine("Enter the username and password");
                authenticate(Console.ReadLine(),Console.ReadLine());
            }
        }
    }
}