namespace ArrayPack{
    class Sequence{

        public String[] myTechnologies={"Spring","JPA","Jinja","Flask","Mode","Express","React","SOAP","DJango","Oracle","MongoDB"};

        public void demoSimpleSort(){
            Array.Sort(myTechnologies);
            // foreach (var item in myTechnologies)
            // {
            //     Console.WriteLine(item);
            // }
        }

        public int demoBinary(String required,int end,int start=0){
            if(start<end){
                int midPosition=end-(start+end)/2;
                //Console.WriteLine(midPosition);
                if(myTechnologies[midPosition].CompareTo(required)==0)
                    return midPosition;
                else if(myTechnologies[midPosition].CompareTo(required)>0)
                    return demoBinary(required,start:start,end:midPosition-1);
                else
                    return demoBinary(required,start:midPosition+1,end:end);
            }
            return -1;
        }

        // O(n)
        public int demoLinear(String required){
            String[] myTechnologies={"Spring","JPA","Jinja","Flask","Mode","Express","React","SOAP","DJango","Oracle","MongoDB"};
            for(int index=0;index<myTechnologies.Length;index++){
                if(myTechnologies[index]==required){
                    return index;
                }
            }
            return -1;
        }

        public void demoUpdate(){
            double[] intrestRate={4.5,9.2,11.8,23.7,11.4,6.5,7.1};
            //intrestRate[0]=5.1; // O(1)
            // conditional based update>> O(n)
            for(int index=0;index<intrestRate.Length;index++){

                if(intrestRate[index]>=11.0){
                    intrestRate[index]+=2;
                }

                Console.WriteLine(intrestRate[index]);
            }
        }

        public void demoRead(){
            String[] myTechnologies={"Spring","JPA","Jinja","Flask","Mode","Express","React","SOAP","DJango","Oracle","MongoDB"};
            Console.WriteLine(myTechnologies[0]);// O(1)
            int start=Convert.ToInt32(Console.ReadLine());
            int end=Convert.ToInt32(Console.ReadLine());
            // O(n)
            while(start<=end){
                Console.WriteLine(myTechnologies[start]);
                start++;
            }
        }

        public void demoCreation(){
            // O(1)
            double[] salaryPacks={4.5,12.5,9.2,3.4,2.1};
            Console.WriteLine(salaryPacks.Length);
            // O(1)
            String[] myEmployees=new String[10];
            Console.WriteLine(myEmployees.Length);
            // index to add/ insert values
            // O(10)    >> O(n)
            for(int index=0;index<myEmployees.Length;index++){
                myEmployees[index]=Console.ReadLine();
            }
            // traverse, search
            // O(n)
            foreach (String pointer in myEmployees)
            {
                Console.WriteLine(pointer);
            }
        }
    }
}