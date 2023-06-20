namespace Blocks{
    class FunctionsRepo{

        // default parameter value
        public void demoFinite(int debit=0,int count=1){
            if(count<=10){
                Console.WriteLine("Current available ");
                double Current=0;
                Current=Convert.ToDouble(Console.ReadLine());
                if(accountBalance>Current){
                    debit++;
                }
                accountBalance=Current;
                count++;
                demoFinite(debit,count);
            }
            else{
                Console.WriteLine(getAccountBalance());
                Console.WriteLine(debit+" debit transactions are happened");
            }
            return;
        }

        public void demoRecusrsive(){
            Console.WriteLine("Demo recursion");
            demoRecusrsive();
        }

        public void deposit(out double balance){
            balance=20000;
        }

        // call by/ pass reference
        public void calculateTransactions(ref double balance){
            String transationType="";int debit=0;
            for(int transation=1;transation<=10;transation++){
                transationType=Console.ReadLine();
                switch(transationType){
                    case "debit":case "withdraw":debit++;break;
                }
            }
            if((debit-3)>0){
                debit-=3;
                balance-=(debit*20);
                Console.WriteLine("Penalty for extra "+debit+" transaction added");
            }
        }

        // call by/ pass value
        public void calculateInterest(double balance){
            balance+=(balance*0.100);
            Console.WriteLine("balance after interest added is "+balance);
        }

        public void fastCash(int required){
            if(accountBalance>=required){
                accountBalance-=required;
                Console.WriteLine("Withdraw success");
            }
            else{
                Console.WriteLine("Insufficient balance");
            }
        }

        Int64 accountNumber=0;
        double accountBalance=0;

        public void setMyData(Int64 accountNumber,double accountBalance){
            this.accountNumber=accountNumber;
            this.accountBalance=accountBalance;
        }

        public void setAccountNumber(Int64 accountNumber){
            this.accountNumber=accountNumber;
        }

        public String setAccountBalance(double accountBal){
            this.accountBalance=accountBal;
            return "Account balance has set";
        }

        public double getAccountBalance(){
            return this.accountBalance;
        }

        public void isLienAccount(){
            if(accountBalance<=10000){
                accountBalance-=(accountBalance*0.100);
            }
            Console.WriteLine(accountNumber+" available balance is "+getAccountBalance());
        }
    }
}