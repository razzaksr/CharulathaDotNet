using SA;

CoreBank coreBank=new CoreBank();

do{
    Console.WriteLine("1.Open Account\n2.Add Beneficiary\n3.Remove Beneficiary\n4.Close account\n5.List Beneficiary\n6.Exit");
    int choice=Convert.ToInt32(Console.ReadLine());
    switch(choice){
        case 1: coreBank.openAccount();break;
        case 2: Console.WriteLine("Enter the beneficiary name, account number and balance");
                KYC kyc=new KYC(Console.ReadLine(),Convert.ToInt64(Console.ReadLine()),Convert.ToDouble(Console.ReadLine()));
                coreBank.addBeneficiary(kyc);
                break;
        case 3: Console.WriteLine("Enter the name of the account holder ");
                coreBank.removeBeneficiary(Console.ReadLine());
                break;
        case 4: Console.WriteLine("Enter the name of the account holder to be closed ");
                coreBank.remove(Console.ReadLine());
                break;
        case 5: 
                List<KYC> temp = coreBank.listAllBeneficiary();
                foreach (var item in temp)
                {
                    Console.WriteLine(item);
                }
                break;
        default: return;
    }
}while(true);

// coreBank.openAccount();
// KYC kyc=new KYC("Mukila",8765678,985.0);
// coreBank.addBeneficiary(kyc);
// List<KYC> temp=coreBank.listAllBeneficiary();
// foreach (var item in temp)
// {
//     Console.WriteLine(item);
// }
// coreBank.remove("Rasheedha");
// coreBank.removeBeneficiary("Charulatha");
