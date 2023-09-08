namespace Gen{
    class MyGenCap<T>{
        T alpha, gamma;

        public MyGenCap(){}
        public MyGenCap(T data1, T data2){
            alpha=data1;
            gamma=data2;
        }

        public override string ToString(){
            return alpha+" "+gamma+"\n";
        }
    }

    class MyGenCouple<A,B>{
        A mars;
        B kepler;
        public MyGenCouple(){}
        public MyGenCouple(A data1,B data2){
            mars=data1;kepler=data2;
        }
        public override string ToString(){
            return mars+" "+kepler+"\n";
        }
    }
}