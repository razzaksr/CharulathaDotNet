using System.Collections;
namespace SA
{
    interface BankingServices{
        public List<KYC> readFromFile();
        public void writeToFile(List<KYC> list);
        public void openAccount();
        public void addBeneficiary(KYC kyc);
        public List<KYC> listAllBeneficiary();
        public void remove(string name);
        public void removeBeneficiary(string holders);
    }
}