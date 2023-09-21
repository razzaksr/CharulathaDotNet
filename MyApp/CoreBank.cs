using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
namespace SA
{
    class CoreBank:BankingServices{

        // permanant data logic
        private FileStream fileStream;
        private BinaryFormatter formatter=new BinaryFormatter();
        private List<KYC> mine;// temporary data logic

        public List<KYC> readFromFile(){
            // deserialization
            try{
                fileStream=new FileStream("mybanks.doc",FileMode.Open);
                mine=(List<KYC>)formatter.Deserialize(fileStream);
                if(mine.Count==0)
                    throw new KycNotFoundException();
                fileStream.Close();
                return mine;
            }
            catch(FileNotFoundException exe){
                fileStream=new FileStream("mybanks.doc",FileMode.Create);
                fileStream.Close();
                return mine=new List<KYC>();
            }
            catch(Exception exe){
                if(exe is EndOfStreamException || exe is KycNotFoundException)
                    Console.WriteLine("Empty database");
                fileStream.Close();
                return mine=new List<KYC>();
            }
        }
        public void writeToFile(List<KYC> list){
            fileStream=new FileStream("mybanks.doc",FileMode.OpenOrCreate);
            formatter.Serialize(fileStream,list);
            // foreach(var each in list){
            //     Console.WriteLine(each);
            // }
            fileStream.Close();
        }

        public void openAccount(){
            Console.WriteLine("Tell us Name, AccNumber and Balance ");
            KYC kyc=new KYC();
            kyc.setHolder(Console.ReadLine());
            kyc.setAccNumber(Convert.ToInt64(Console.ReadLine()));
            kyc.setAccBalance(Convert.ToDouble(Console.ReadLine()));
            mine=readFromFile();// read
            mine.Add(kyc);
            writeToFile(mine);//write
            Console.WriteLine(kyc.getHolder()+" has openned the account");
        }
        public void addBeneficiary(KYC kyc){
            mine=readFromFile();
            Console.WriteLine("Choose who wish to add "+kyc.getHolder()+" beneficiary ");
            string name=Console.ReadLine();
            try{
                for(int index=0;index<mine.Count;index++)
                {
                    if(name==mine[index].getHolder()){
                        mine[index].getBeneficiaries().Add(kyc);
                        writeToFile(mine);
                        Console.WriteLine(kyc.getHolder()+" has added as beneficiary to "+name);
                        return;
                    }
                }
                throw new KycNotFoundException();
            }
            catch(KycNotFoundException k){
                Console.WriteLine(k);
            }
        }
        public List<KYC> listAllBeneficiary(){
            Console.WriteLine("Choose which holder's beneficiaries to be shown ");
            string name=Console.ReadLine();
            mine=readFromFile();
            try{
                for(int index=0;index<mine.Count;index++)
                {
                    if(name==mine[index].getHolder()){
                        return mine[index].getBeneficiaries();
                    }
                }
                throw new KycNotFoundException();
            }
            catch(KycNotFoundException k){
                Console.WriteLine(k);
                return new List<KYC>();
            }
        }
        public void remove(string name){
            mine=readFromFile();
            try{
                for(int index=0;index<mine.Count;index++)
                {
                    if(name==mine[index].getHolder()){
                        mine.Remove(mine[index]);
                        writeToFile(mine);
                        Console.WriteLine(name+" has closed the account");
                        return;
                    }
                }
                throw new KycNotFoundException();
            }
            catch(KycNotFoundException k){
                Console.WriteLine(k);
            }
        }
        public void removeBeneficiary(string holders){
            mine=readFromFile();
            try{
                for(int index=0;index<mine.Count;index++)
                {
                    if(holders==mine[index].getHolder()){
                        foreach (var item in mine[index].getBeneficiaries())
                        {
                            Console.WriteLine(item.getHolder());
                        }
                        Console.WriteLine("Enter any beneficiary to remove");
                        string ben=Console.ReadLine();
                        for(int pos=0;pos<mine[index].getBeneficiaries().Count;pos++){
                            if(ben==mine[index].getBeneficiaries()[pos].getHolder()){
                                mine[index].getBeneficiaries().Remove(mine[index].getBeneficiaries()[pos]);
                                writeToFile(mine);
                                Console.WriteLine(ben+" has removed from the Beneficiary List of "+holders);
                                return;
                            }
                        }
                        throw new KycNotFoundException();
                    }
                }
                throw new KycNotFoundException();
            }
            catch(KycNotFoundException k){
                Console.WriteLine(k);
            }
        }
    }
}