using encap;
namespace Heritance{
    // derivedclass:baseclass
    class DebitCard:KYC{
        public int pin{set;get;}
        public DebitCard(int pin, Int64 accNum, double accBal, String holder):base(accNum,accBal,holder){
            this.pin=pin;
        }

        public bool isValid(int curPin){
            if(this.pin==curPin)
                return true;
            else
                return false;
        }

        public static DebitCard operator >> (DebitCard debitCard,int amount){
            Console.WriteLine("Enter the pin to verify ");
            int myPin=Convert.ToInt32(Console.ReadLine());
            if(debitCard.isValid(myPin)==true){
                debitCard.accBal+=amount;
                Console.WriteLine(amount+" has deposited");
            }
            else{
                Console.WriteLine("Unauthoriser");
            }
            return debitCard;
        }

        // public static DebitCard operator -- (DebitCard debitCard){
        //     Console.WriteLine("Enter the pin ");
        //     int myPin=Convert.ToInt32(Console.ReadLine());
        //     if(debitCard.isValid(myPin)){
        //         Console.WriteLine("Enter the amount to debit");
        //         int amount = Convert.ToInt32(Console.ReadLine());
        //         if(amount<=debitCard.accBal){
        //             debitCard.accBal-=amount;
        //             Console.WriteLine(amount+" withdrawl has success");
        //         }
        //         else{
        //             Console.WriteLine("Invalid transaction amount");
        //         }
        //     }
        //     else{
        //         Console.WriteLine("unauthoriser");
        //     }
        //     return debitCard;
        // }
        public void withdraw (int amount){
            Console.WriteLine("Enter the pin ");
            int myPin=Convert.ToInt32(Console.ReadLine());
            if(isValid(myPin)){
                if(amount<=accBal){
                    accBal-=amount;
                    Console.WriteLine(amount+" withdrawl has success");
                }
                else{
                    Console.WriteLine("Invalid transaction amount");
                }
            }
            else{
                Console.WriteLine("unauthoriser");
            }
        }

    }
}