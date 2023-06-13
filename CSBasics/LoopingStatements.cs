namespace Loop{
    class LoopState{

        // loop sequential process
        /*
        loop1: init,cond,iter
            loop1 body
            
            loop2: init, cond, iter
                loop2 body
            
            loop1 body
        */

        public static void DemoPerfectSquare(){
            int size=0, even=2;
            Console.WriteLine("Enter the size of perfect square ");
            size=Convert.ToInt32(Console.ReadLine());
            for(int row=1;row<=size;row++){
                for(int column=1;column<=size;column++,even+=2){
                    Console.Write(even+" ");
                }
                Console.WriteLine();
            }
        }

        public static void DemoRealNested(){
            int fare=0, seats=50, required=0, bus=1, time=0, totalCollection=0;
            while(bus<=3){
                time=1;
                seats=50;
                while(seats>0&&time<=20){
                    Console.WriteLine("Enter the number tickets required for "+bus+"th bus ");
                    required=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the amount ");
                    fare=Convert.ToInt32(Console.ReadLine());
                    if(fare>=(required*250)){
                        seats-=required;
                        Console.WriteLine(required+" Seat(s) are booked");
                        if(fare>(required*250)){
                            Console.WriteLine("Get remianing change "+(fare-(required*250)));
                        }
                    }
                    else{
                        Console.WriteLine(required+" Seat(s) are not booked");
                    }
                    time++;
                }
                Console.WriteLine("Bus "+bus+" booked "+(50-seats)+" and collected amount is "+((50-seats)*250));
                totalCollection+=((50-seats)*250);
                bus++;
            }
            Console.WriteLine("Total collection of the day "+totalCollection);
        }

        public static void DemoNested(){
            for(int table=1;table<=10;table++){
                for(int number=1;number<=10;number++){
                    Console.WriteLine(number+" X "+table+" = "+(table*number));
                }
            }
        }


        // Non linear iteration with multiple loop condition
        public static void FlashSale(){
            double timer=12.00;int invoice=0;
            for(int stock=40, required=0;stock>0&&timer<=12.60;timer+=0.01){
                Console.WriteLine("Enter the number of mobiles required ");
                required=Convert.ToInt32(Console.ReadLine());
                if(required<=stock){
                    stock-=required;
                    Console.WriteLine("Expected amount of "+required+" mobiles order has placed");
                    invoice++;
                }
                else{
                    Console.WriteLine("Insufficient stock "+stock);
                }
            }
            Console.WriteLine(invoice+" bills have generated");
        }

        // linear iteration with multiple conditions
        public static void TrainBooking(){
            String gender="";
            for(int seats=10, age=0;seats>0;){
                Console.WriteLine("Enter the gender ");
                gender=Console.ReadLine();
                Console.WriteLine("Enter the age ");
                age=Convert.ToInt32(Console.ReadLine());
                if(age>=50&&gender=="Female"||age>=55&&gender=="Male"){
                    seats--;
                    Console.WriteLine("You will get 50% of fare concession since gender is "+gender+" and Age is "+age);
                }
                else{
                    Console.WriteLine("You are not eligible to get 50% of fare concession");
                }
            }
        }

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
        // non linear and condition based
        public static void RationShop(){
            int familyCount=0, bills=0;
            for(double sugarStock=100, currentKg=0;sugarStock>0;){
                Console.WriteLine("How may family members ");
                familyCount=Convert.ToInt32(Console.ReadLine());
                if(familyCount>=2){
                    currentKg=(familyCount*0.5);
                    if(currentKg<=sugarStock){
                        sugarStock-=currentKg;
                        Console.WriteLine("You will get "+currentKg+"KG amount of sugar");
                        bills++;
                    }
                    else{
                        Console.WriteLine(sugarStock+"KG is available");
                    }
                }
                else{
                    Console.WriteLine("You are not eligible to get sugar");
                }
            }
            Console.WriteLine(bills+" billed for the 100KG of SUGAR");
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