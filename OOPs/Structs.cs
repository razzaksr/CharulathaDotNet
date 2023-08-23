namespace Heritance
{
    struct Block
    {
        public String upiId;
        public int upiPin;
        public double accBalance;

        public void show(){
            Console.WriteLine(upiId+" "+accBalance);
        }
    }
}