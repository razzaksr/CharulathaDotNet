/*
Decision Making/ Control statements
if:
if(cond){
    // true block
}
if else:
if(cond){
    true block
}
else{
    false block
}
if else if....else :
if(cond){
    true block
}
else if(cond){
    true block
}
else if(cond){
    true block
}
.
.
.
else{
    false block
}
nested if:
if(cond1){
    true1 block
    if(cond2){
        true2 block
    }
    else{
        //false to cond2
    }
}
else{
    false to cond1
}

switch: String/int/char
switch(choice){
    case : break;
    case : break;
    case : break;
    case : break;
}
*/
namespace Decision{
    class Controls{
        public static void DemoIf(){
            Console.WriteLine("Enter the desired amount to withdraw: ");
            int desired=Convert.ToInt32(Console.ReadLine());
            if(desired%2000==0){
                int noOfCurrency=desired/2000;
                Console.WriteLine(noOfCurrency+" X 2000's you will get for "+desired);
            }
        }
        public static void DemoIfElse(){
            int machineMaximum=20000;
            Console.WriteLine("Enter the desired amount to withdraw ");
            int desired=Convert.ToInt32(Console.ReadLine());
            if(desired<=machineMaximum){
                Console.WriteLine("Denomination checking process....");
            }
            else{
                Console.WriteLine("Insufficient amount in the machine");
            }
        }
        public static void DemoNested(){
            int _2000s=15, _500s=10, machineMaximum=0, required=0;
            machineMaximum=(_2000s*2000) + (_500s*500);// 30000
            Console.WriteLine("Enter the desired amount to withdraw ");
            int desired=Convert.ToInt32(Console.ReadLine());
            if(desired<=machineMaximum&&desired%2000==0){
                Console.WriteLine("Denomination checking process....");
                required=desired/2000;
                if(required<=_2000s){
                    _2000s-=required;
                    Console.WriteLine(required+" X 2000's you will get for "+desired);
                }
                else{
                    Console.WriteLine(_2000s+"only available");
                }
            }
            else{
                Console.WriteLine("Insufficient amount in the machine");
            }     
        }
        public static void DemoElseIfLadder(){
            // income Tax slab
            Console.WriteLine("Annual CTC ");
            double ctc=Convert.ToDouble(Console.ReadLine());
            double takeHome=0.0, tax=0.0;
            if(ctc>=2.5&&ctc<=5.0){
                Console.WriteLine("No TAX deduction for ctc "+ctc+" if you have insurance ");
            }
            else if(ctc>5.0&&ctc<=10.0){
                Console.WriteLine("You suppose to pay 5% tax from your ctc "+ctc);
                tax=5.0;
            }
            else if(ctc>10.0&&ctc<=20.0){
                Console.WriteLine("You suppose to pay 10% tax from your ctc "+ctc);
                tax=10.0;
            }
            else if(ctc>20.0&&ctc<=25.0){
                Console.WriteLine("You suppose to pay 15% tax from your ctc "+ctc);
                tax=15.0;
            }
            else if(ctc>25.0&&ctc<=30.0){
                Console.WriteLine("You suppose to pay 20% tax from your ctc "+ctc);
                tax=20.0;
            }
            else if(ctc>30.0){
                Console.WriteLine("You suppose to pay 30% tax from your ctc "+ctc);
                tax=30.0;
            }
            else{
                Console.WriteLine("No need to pay tax for ctc "+ctc);
            }
            takeHome=ctc-(ctc*tax)/100;
            Console.WriteLine("Your take home salary "+takeHome+" from your CTC "+ctc+" after tax "+tax+"% deductions");
        }
        public static void DemoSwitch(){
            Console.WriteLine("-----------------Welcome to Kallada travels-----------");
            Console.WriteLine("Enter the destination to travel with US");
            String destination=Console.ReadLine();
            switch(destination){
                case "Chennai":case "chennai":case "villupuram":case "chengulpat":case "tambaram":
                Console.WriteLine("We have NON-AC sleeper departure @11pm to "+destination);
                break;
                case "Cochin":case "cochin":Console.WriteLine("We have AC-Seater departure @12am to Cochin");break;
                case "Kanyakumari":case "kanyakumari":Console.WriteLine("We have AC-Sleeper depature @8.30pm to kamyakumari");break;
                default:Console.WriteLine("No services to "+destination);break;
            }
        }
    }
}