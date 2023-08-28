using System.Collections;

namespace MyThread{
    class WorkForce{
        // int[] arr={7, 5, 1, 6, 8};
        int[] arr;
        public void findMinLossMaxProfit(){
            lock (this)
            {
                Console.WriteLine("Enter the no of stock history");
                Int32 size=Convert.ToInt32(Console.ReadLine());
                arr=new int[size];
                for(int index=0;index<arr.Length;index++){
                    Console.WriteLine("Stock price ");
                    arr[index]=Convert.ToInt32(Console.ReadLine());
                }
                if(arr.Length<2){
                    Console.WriteLine("Invalid array/ stock history");
                    return;
                }
                else{
                    int currentBuy=arr[0];// 7
                    int currentSell=arr[1];// 5

                    int maxProfit=currentSell-currentBuy;

                    int currentProfit=Int32.MinValue;// -100000000

                    for(int index=1;index<arr.Length;index++){
                        currentProfit=arr[index]-currentBuy;// -2
                        if(currentProfit>maxProfit){
                            maxProfit=currentProfit;
                            currentSell=arr[index];
                        }
                        if(currentBuy>arr[index]){
                            currentBuy=arr[index];
                        }
                    }

                    int found=currentSell-maxProfit;
                    if(found>currentSell){
                        Console.WriteLine(Thread.CurrentThread.Name+" please wait for a while to see your loss ");
                        Thread.Sleep(5000);
                    }
                    Console.WriteLine("When to sell "+currentSell+" of buying price "+found);
                }
            }
        }
    }
}