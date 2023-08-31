namespace Handle{
    class Navigate{
        public static int[] arr={45000,11000,4999,1299,8999,12455};
        public static int index, installment;

        public static void show(){
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void perform(){
            try{
                show();
                Console.WriteLine("Choose product by position ");
                index=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the feasible month to repay "+arr[index]);
                installment=Convert.ToInt32(Console.ReadLine());
                int EMI=arr[index]/installment;
                Console.WriteLine(EMI+" EMI of product "+arr[index]+" for month of "+installment);
            }
            catch(IndexOutOfRangeException indOut){
                Console.WriteLine(indOut+" same Context");
                throw indOut;
            }
            catch(DivideByZeroException divide){
                Console.WriteLine("Monthly installment should be more than 1");
                installment=Convert.ToInt32(Console.ReadLine());
                int EMI=arr[index]/installment;
                Console.WriteLine(EMI+" EMI of product "+arr[index]+" for month of "+installment);
            }
        }
    }
}