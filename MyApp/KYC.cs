using System.Collections;
using System.IO;
namespace SA
{
    [Serializable]
    class KYC{
        private string holder;
        private long accNumber;
        private double accBalance;
        private List<KYC> beneficiaries=new List<KYC>();

        public void setBeneficiaries(List<KYC> list){this.beneficiaries=list;}
        public List<KYC> getBeneficiaries(){return beneficiaries;}
        
        public void setHolder(string holder){this.holder=holder;}
        public void setAccNumber(long accNumber){this.accNumber=accNumber;}
        public void setAccBalance(double accBalance){this.accBalance=accBalance;}

        public KYC(){}
        public KYC(string holder, long accNumber,double accBalance){
            this.accNumber=accNumber;this.holder=holder;this.accBalance=accBalance;
        }

        public string getHolder(){return holder;}
        public long getAccNumber(){return accNumber;}
        public double getAccBalance(){return accBalance;}

        public override string ToString(){
            return "Account details are, Name of the holder "+holder+" account number is "+accNumber+" availabale balance is "+accBalance+"\n";
        }
    }
}