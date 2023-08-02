namespace Heritance{
    class Netbanking:DebitCard{
        //public Netbanking(int pin):base(pin){}
        public Netbanking(int pin, Int64 accNum, double accBal, String holder):base(pin,accNum,accBal,holder){}
        //netbank1-netbank2
        public static Netbanking operator - (Netbanking source, Netbanking desitination){
            if(desitination!=null){
                Console.WriteLine("Enter the amount to transfer to "+desitination.holder);
                int amount=Convert.ToInt32(Console.ReadLine());
                if(source.accBal>=amount){
                    Console.WriteLine("Enter the pin to verify ");
                    int myPin=Convert.ToInt32(Console.ReadLine());
                    if(source.isValid(myPin)==true){
                        source.accBal-=amount;
                        desitination.accBal+=amount;
                        Console.WriteLine(amount+" has trasferred to "+desitination.holder);
                    }
                    else{
                        Console.WriteLine(source.holder+" authentication failed");
                    }
                }
                else{
                    Console.WriteLine("Insufficient amount to transfer to "+desitination.holder);
                }
            }
            else{
                Console.WriteLine("Invalid beneficiary");
            }
            return source;
        }
    }
}