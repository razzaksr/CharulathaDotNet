namespace Operations{
    class Operators{
        public static void logicals(){
            // bool >> True/False
            // && || 
            // Console.WriteLine("Enter the amount to withdraw ");
            // int amount=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Will i get my "+amount+", "+((amount%2000==0)||(amount%500==0)));

            Console.WriteLine("Enter the income ");
            double income=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Source of income ");
            String source=Console.ReadLine();
            Console.WriteLine("Will i get PL of 2Lacks, "+((source=="salary")&&(income>=3.1)));
        }
        public static void relational(){
            // bool >> True/False
            // > >= < <= == !=
            // Console.WriteLine("Enter your annual salary to check eligible to pay tax ");
            // Double ctc=Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Am i need to pay tax "+(ctc>=3.5));

            Console.WriteLine("Enter the password ");
            String password=Console.ReadLine();
            //Console.WriteLine("Am I entered invalid length "+(password.Length<=8));
            //Console.WriteLine("Am I authorised user "+(password=="zealousalem"));
            Console.WriteLine("Was my password invlaid, "+!password.Contains(" "));
        }
        public void arithmetic(){
            // +-*/%
            // float currentCTC=4.5F, expectedHike=0.0F, apprisal=0.0F;
            // Console.WriteLine("Enter the percentage to be added for your current CTC "+currentCTC);
            // apprisal=float.Parse(Console.ReadLine());
            // expectedHike=currentCTC+(currentCTC*apprisal)/100;
            // Console.WriteLine("Your expected CTC would be "+expectedHike+" from your current "+currentCTC+" with the apprisal of "+apprisal);

            Int32 expectedAmount=0;
            Console.WriteLine("Enter the amount to withdraw: ");
            expectedAmount=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Will you get your desired amount "+expectedAmount+" ,"+(expectedAmount%2000==0));
        }
        public void unary(){
            // ++ --
            // implict casting
            char alpha='b';int cosmo='Q';// A-65 Z-90 a-97 z-122
            Console.WriteLine(cosmo+" "+alpha);
            char sigma=(char)cosmo;// explict casting
            Console.WriteLine(sigma);
            int delta=alpha;// implcit casting
            Console.WriteLine(delta+" "+cosmo);
            Console.WriteLine(alpha+" "+sigma);
            Console.WriteLine(alpha-- +" "+ ++sigma);// b R
            Console.WriteLine(--alpha +" "+ sigma++);// ` R
            Console.WriteLine(alpha+" "+sigma);
        }
        public void expression(){
            // Brackets Of Div-Mul Add-Sub
            char racoon='R', quill='s';
            Console.WriteLine(racoon+" "+quill);
            //Console.WriteLine((racoon++)+(--quill)-(--racoon));// R+r-R>> 82+114-82>>
            //Console.WriteLine((++quill)+(--racoon)*(quill/2));// t+Q*t/2>> 116+81*116/2>>
            Console.WriteLine((quill--)-(--racoon)/(quill+10)+(++quill)*(racoon%2));
            // s-Q/r+10 +s*Q%2>> 115-81/124+115*1>> 230
        }
        public static void shortHand(){
            // += -= *= /= %=
            // leftVar = leftVar Symbol rightVar
            // leftVar Symbol=rightVar

            // swapping
            double sportz=3.4, third=0;int magna=12;
            Console.WriteLine(sportz+" "+magna);
            // third varibale
            // third=sportz;
            // sportz=magna;
            // magna=(int)third;

            // using + -
            sportz+=magna;//sportz=sportz+magna;
            magna=(int)sportz-magna;
            sportz-=magna;//sportz=sportz-magna;

            // using * /
            // sportz*=magna;//sportz=sportz+magna;
            // magna=(int)sportz/magna;
            // sportz/=magna;//sportz=sportz-magna;
            Console.WriteLine(sportz+" "+magna);
        }
        public static void bitwise(){
            // & | ^ >> <<
            // 8192 4096 2048 1024 256 128 64 32 16 8 4 2 1
            //    0    0    0    0   0   0  1  1  1 1 0 1 0 >> 122>> mantis
            //    0    0    0    0   0   0  0  0  0 0 0 1 1 >>   3>>
            //    0    0    0    0   0   0  0  0  1 1 1 1 0 >>  31>>nebula
            //    0    0    0    0   0   0  1  1  1 0 0 0 0 >> 112>>groot
            //    0    0    0    0   0   0  1  1  0 1 1 1 0 >> 110>>nebula
            //    0    0    0    0   0   0  0  0  1 1 1 1 0 >>  31>>groot
            //    0    0    0    0   0   0  1  1  1 0 0 0 0 >> 112>>nebula
            //    0    0    0    0   0   0  0  0  0 0 1 0 1 >> 5
            //    0    0    0    0   0   1  0  1  1 1 1 1 0 >> 190

            //    0    0    0    0   0   0  1  1  1 1 0 1 0 >> 122
            //    0    0    0    0   0   0  1  0  1 0 1 1 1 >>  87
            //    0    0    0    0   0   0  0  1  0 1 1 0 1 >>  45
            //    0    0    0    0   0   0  0  1  0 1 1 0 0 >>  44
            //    0    0    0    0   0   0  0  1  0 1 0 0 0 >>  40

            //    0    0    0    0   1   0  1  0  1 1 0 0 0 >> 344
            //    0    0    0    0   0   0  1  0  0 0 0 0 1 >>  65
            //    0    0    0    0   1   0  1  0  1 1 0 0 1 >> 345


            char mantis='z';int gamora=344;

            Console.WriteLine(mantis&44);

            Console.WriteLine(gamora|'A');

            Console.WriteLine(mantis^'W');

            int nebula=31, groot=112;
            
            Console.WriteLine(nebula+" "+groot);
            nebula^=groot;
            groot^=nebula;
            nebula^=groot;
            Console.WriteLine(nebula+" "+groot);

            // shift operators:
            Console.WriteLine(mantis>>5);
            Console.WriteLine(mantis<<2);

            char original='s', sending='\0', received='\0';
            sending=(char)(original<<2);
            Console.WriteLine(sending);
            received=(char)(sending>>2);
            Console.WriteLine(received);
        }
    }
}