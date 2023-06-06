namespace Loop{
    class LoopState{
        //linear condition based
        public static void CreditCard(){
            int cibil=0, target=10;
            while(target>=0){
                Console.WriteLine("Enter the cibil score ");
                cibil=Convert.ToInt32(Console.ReadLine());
                if(cibil>=600){
                    Console.WriteLine("You are eligible to get ICICI Premium Credit card");
                    target--;
                }
                else{
                    Console.WriteLine("You're not eligbile to get CreditCard");
                }
            }
        }
        public static void RationShop(){
            // non linear

        }
        public static void DemoWhile(){
            int number=51;//init
            //cond
            //while(true){
            while(number<=100){
                if(number==2||number==3||number==5||number==7||number%2!=0&&
                number%3!=0&&number%5!=0&&number%7!=0){
                    Console.WriteLine(number+" is prime");
                }
                number++;//iter
            }
        }
        public static void DemoDo(){
            int number=151;//init
            do{
                if(number==2||number==3||number==5||number==7||number%2!=0&&
                number%3!=0&&number%5!=0&&number%7!=0){
                    Console.WriteLine(number+" is prime");
                }
                number++;//iter
            }while(number<=100);//cond
            //}while(true);//cond
        }
        public static void DemoFor(){
            //for(;;){}
            //int number=11;
            for(int number=11;;){
                if(number==2||number==3||number==5||number==7||number%2!=0&&
                number%3!=0&&number%5!=0&&number%7!=0){
                    Console.WriteLine(number+" is prime");
                }
                //number++;//iter
            }
        }
    }
}