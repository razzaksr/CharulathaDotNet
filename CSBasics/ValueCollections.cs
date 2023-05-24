// Demonstration on varibale and scopes
namespace MyInputs{
    class Stat{
        // literal object
        public String? myOrg ="Zealous Tech Corp";// class level member

        public void switchOrg(){
            myOrg="TietoEvry";
        }

        public void quitJob(){
            myOrg=null;
        }

    }

    // demosntration of local members
    class MindBlow{
        public String? myOrg;// class level member

        public void groot(){
            Double mySalary=14.5;// local member to the groot method
            Console.WriteLine("My salary is "+mySalary);
        }

        public void aprisal(){
            
        }

    }
}