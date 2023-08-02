namespace Heritance{
    class BharatPay:DebitCard{

        int[] bills={7812,120,870,200,50,425};

        public BharatPay(int pin, Int64 accNum, double accBal, String holder):base(pin,accNum,accBal,holder){}

        public void payBills(){
            for (int bill = 0; bill < bills.Length; bill++)
            {
                Console.WriteLine("Do you consent to pay bill amount "+bills[bill]);
                String consent=Console.ReadLine();
                switch(consent){
                    case "YES":case "yes": case "ok": case "okay":
                        Console.WriteLine("Enter the pin to begin bill pay ");
                        int myPin=Convert.ToInt32(Console.ReadLine());
                        if(bills[bill]<accBal&&isValid(myPin)){
                            accBal-=bills[bill];
                            Console.WriteLine(bills[bill]+" has paid by "+holder);
                            bills[bill]=0;
                        }
                        else{
                            Console.WriteLine("Invalid PIN/ Balance");
                        }
                        break;
                    default:Console.WriteLine(bills[bill]+" ignored to pay");break;
                }
            }
        }
        
    }
}