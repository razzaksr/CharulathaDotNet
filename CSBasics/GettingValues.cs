namespace MyInputs{
    class UserDefinedValues{
        public void drax(){
            Int32 myExperience=8;
            Console.WriteLine("Let us know your experience ");
            //myExperience=Int32.Parse(Console.ReadLine());
            myExperience=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My experience is "+myExperience);
        }
    }
}