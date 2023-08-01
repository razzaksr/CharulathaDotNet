namespace Heritance{
    class GPay{
        public int hi,bye;
        public GPay(){Console.WriteLine("Default GPay construction");}
        public GPay(int alpha,int beta){
            hi=alpha;bye=beta;
            Console.WriteLine("GPay parameterized constructor called values assigned");
        }
    }

    class Paytm:GPay{
        public Paytm(){Console.WriteLine("Default Paytm construction");}
        // public Paytm(int cosmo,int delta):base(cosmo,delta){
        // }
        public Paytm(int cosmo,int delta){
            hi=cosmo;bye=delta;
            Console.WriteLine(hi+" "+bye);
        }
    }
}