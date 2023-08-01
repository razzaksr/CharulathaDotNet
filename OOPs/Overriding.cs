namespace Heritance{
    class Wallet{
        public int balance;
        public void transaction(int desired){
            if(desired<=balance){
                balance-=desired;
                Console.WriteLine(desired+" has debited");
            }
            else{
                Console.WriteLine("Insufficient to debit "+desired);
            }
        }
    }

    class PhonePe:Wallet{
        public PhonePe(){}

        public new void transaction(int amount){
            balance+=amount;
            Console.WriteLine(amount+" credited");
        }

        public void debiting(int amount){
            base.transaction(amount);
        }

        public PhonePe(int myBalance){
            balance=myBalance;
        }
        public void available(){
            Console.WriteLine("Available balance is "+balance);
        }
    }
}