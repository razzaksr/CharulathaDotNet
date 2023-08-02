namespace encap{

    class Valhella{
        Valhella(){}
        static Valhella valhella=new Valhella();

        public static Valhella getValhella(){
            return valhella;
        }

        int[] marc={90,45,13,45,4,56,67,56};
        public void list(){
            foreach (var item in marc)
            {
                Console.WriteLine(item);
            }
        }
    }

    class KYC{
        // default constructor
        public KYC(){}

        // parameterized constructor
        public KYC(Int64 accNum, double accBal, String holder){
            this.accNum=accNum;this.accBal=accBal;this.holder=holder;
        }
        public Int64 accNum{set;get;}
        public double accBal{set;get;}
        public String holder{set;get;}

        public override String ToString(){
            return holder+" "+accNum+" "+accBal;
        }

        public static KYC operator<<(KYC kyc,int amount){
            if(kyc.accBal>=amount){
                kyc.accBal-=amount;
            }
            return kyc;
        }
    }

    class Offline{
        public void openAccount(){
            KYC kyc = new KYC();
            
        }
    }
}