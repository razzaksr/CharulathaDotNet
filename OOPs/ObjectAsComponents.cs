namespace Objects{

    class Trio{

        public void call(){
            Thor thor=new Thor();
            Console.WriteLine(thor.accessed("Nano"));
        }

        class Tony{
            String[] techs={"Missles","Sheild","Vibranium","Nano"};
            public String[] getTechs(){
                return techs;
            }
        }
        public class Thor{
            Tony tony=new Tony();
            public int accessed(String data){
                for(int index=0;index<tony.getTechs().Length;index++){
                    if(tony.getTechs()[index].CompareTo(data)==0){
                        return index;
                    }
                }
                return -1;
            }
        }
    }

    class Afa{
        int[] marc={90,45,13,45,456,67,56};

        // setters and getters
        public void setMarc(int[] array){
            this.marc=array;
        }
        public int[] getMarc(){
            return marc;
        }
    }

    class Sika{
        Afa afa=new Afa();// Object as component

        public void showSome(){
            foreach (var item in afa.getMarc())
            {
                Console.WriteLine(item);
            }
        }
    }
}