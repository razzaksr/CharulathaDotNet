namespace ArrayPack{
    class Sequence{

        public void marshmallow(){
            int[] myExperience={9,1,4,12,8,4,0,1,2};
            //recruit(myExperience);
            perform(myExperience);
            recruit(myExperience);
        }

        public void perform(int[] arr){
            for(int index=0;index<arr.Length;index++){
                if(arr[index]<=5)
                    arr[index]+=1;
            }
        }

        public void recruit(int[] wind){
            for(int index=0;index<wind.Length;index++){
                if(wind[index]>=5)
                    Console.WriteLine("You are recruited because of the experience "+wind[index]);
            }
        }

        public int detectPivot(int start,int end){
            String transfer="";
            String pivotData = myTechnologies[end];
            int initial=start-1;

            for(int current=start;current<end;current++){
                if(myTechnologies[current].CompareTo(pivotData)<0){
                    initial++;
                    transfer=myTechnologies[initial];
                    myTechnologies[initial]=myTechnologies[current];
                    myTechnologies[current]=transfer;
                }
            }

            transfer=myTechnologies[initial+1];
            myTechnologies[initial+1]=myTechnologies[end];
            myTechnologies[end]=transfer;

            return initial+1;
        }

        // O(nlogn)
        public void demoQuick(int start,int end){
            if(start<end){
                int pivotalPoint=detectPivot(start,end);
                demoQuick(start,pivotalPoint-1);
                demoQuick(pivotalPoint+1,end);
            }
        }

        public void demoBubble(){
            String persist="";
            for(int bubble1=0;bubble1<myTechnologies.Length-1;bubble1++){
                for(int bubble2=0;bubble2<myTechnologies.Length-bubble1-1;bubble2++){
                    if(myTechnologies[bubble2].CompareTo(myTechnologies[bubble2+1])<0){
                        persist=myTechnologies[bubble2];
                        myTechnologies[bubble2]=myTechnologies[bubble2+1];
                        myTechnologies[bubble2+1]=persist;
                    }
                }
            }
        }

        // O(n2)
        public void demoSelection(){
            String hold="";
            for(int select=0;select<myTechnologies.Length;select++){
                for(int comparison=select+1;comparison<myTechnologies.Length;comparison++){
                    if(myTechnologies[select].CompareTo(myTechnologies[comparison])>0){
                        hold=myTechnologies[select];
                        myTechnologies[select]=myTechnologies[comparison];
                        myTechnologies[comparison]=hold;
                    }
                }
            }
        }

        public String[] myTechnologies={"Spring","JPA","Jinja","Flask","Mode","Express","React","SOAP","DJango","Oracle","MongoDB"};

        public void getMyTechnologies(){
            foreach (var item in myTechnologies)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine();
        }

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