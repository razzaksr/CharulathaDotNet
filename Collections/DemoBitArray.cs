using System.Collections;
namespace Collect
{

    /*
        
    */
    class DemoBitArray{
        // & | ! ^
        public void demoBits(){
            byte[] array1={42};byte[] array2={12};

            BitArray bitArr1=new BitArray(array1);

            foreach (var item in bitArr1)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            BitArray bitArr2=new BitArray(array2);

            BitArray bitArray3=bitArr1.Or(bitArr2);

            for(int index=0;index<bitArray3.Count;index++){
                Console.Write(bitArray3[index]+" ");
            }
            Console.WriteLine();
        }
    }
}