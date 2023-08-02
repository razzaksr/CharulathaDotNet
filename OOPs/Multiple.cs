namespace Heritance{
    // class UPI:Netbanking,BharatPay{

    // }

    interface SampleFace{
        // data members are constant
        const String framework="DJango";

        void modify();
    }

    // single inheritance
    class MyFaceInter:SampleFace{
        public void myOwn(){
            Console.WriteLine("Derived's own method");
        }
        public void modify(){
            Console.WriteLine("Overriden from SampleFace");
        }
    }

}