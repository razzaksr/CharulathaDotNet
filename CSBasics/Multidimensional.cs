namespace ArrayPack{
    class Dimension{
        public double[,] cat={{3.4,8.8,12.8},{14.8,29.5,45.8},{4.1,16.3,27.3},{1.1,78.8,91.7}};
        public void multiBin(double data,int row=0, int start=0, int end=2){
            if(row<4){
                if(start<end){
                    int mid=end-(start+end)/2;
                    Console.WriteLine(cat[row,mid]+" row "+row+" start "+start+" end "+end);
                    if(cat[row,mid]==data){
                        Console.WriteLine(data+" found @ "+row+" in "+mid);
                        return;
                    }
                    else if(cat[row,mid]>data){
                        //Console.WriteLine("1st else if");
                        multiBin(data,row,0,mid-1);
                    }
                    else{
                        multiBin(data,row,start:mid+1,end:end);
                    }
                }
                else{
                    row++;
                    multiBin(data,row,start=0,end=2);
                }
            }
            else{
                Console.WriteLine("Not found anywhere");
            }
        }
        Object[][] opennings=new Object[3][];
        // O(n2)
        public void insertion(){
            for(int floor=0;floor<opennings.Length;floor++){
                Console.WriteLine("Tell us how many flat in "+floor+"th floor");
                opennings[floor]=new Object[Convert.ToInt32(Console.ReadLine())];
                for(int door=0;door<opennings[floor].Length;door++){
                    Console.WriteLine("enter the details of "+floor+" in the "+door);
                    if(door%2!=0){
                        opennings[floor][door]=Convert.ToInt32(Console.ReadLine());
                    }
                    else{
                        opennings[floor][door]=Console.ReadLine();
                    }
                }
            }
        }
        public void traverse(){
            foreach (Object[] item in opennings)
            {
                foreach (var details in item)
                {
                    Console.Write(details+" ");
                }
                Console.WriteLine();
            }
        }
        public void copy(){
            int[,] data={{89,34,10,55,88},{31,82,20,43,20},{11,66,24,64,24}};
            int[] copyData=new int[15];
            int row=0,col=0, index=0;
            while(col<5){
                copyData[index]=data[row,col];
                index++;
                col++;
            }
            col--;row++;
            while(row<3){
                copyData[index]=data[row,col];
                row++;
                index++;
            }
            row--;col--;
            while(col>=0){
                copyData[index]=data[row,col];
                col--;
                index++;
            }
            row--;col++;
            copyData[index]=data[row,col];
            index++;
            col++;
            while(col<4){
                copyData[index]=data[row,col];
                col++;
                index++;
            }

            foreach (var item in copyData)
            {
                Console.Write(item+" ");
            }
        }
    }
}