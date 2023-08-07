namespace Heritance
{
    class Alphabet{
        string[] arr={"DJango","Flask","Jinja","Flutter","React native","Go lang","Vue","Angular","Java"};
        public void show(){
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public string[] getArr(){
            return arr;
        }
    }
    interface PerformAlpha{
        public int binSearch(string data);
    }

    class Multiple:Alphabet,PerformAlpha{
        public int binSearch(string data){
            if(getArr().Length<=0)
                return -1;
            else{
                Array.Sort(getArr());
                show();
                int start=0,end=getArr().Length-1;
                while(start<=end){
                    int mid=start+(end-start)/2;
                    if(getArr()[mid].Equals(data))
                        return mid;
                    else if(getArr()[mid].CompareTo(data)<0)
                        start=mid+1;
                    else
                        end=mid-1;
                }
            }
            return -1;
        }
    }
}