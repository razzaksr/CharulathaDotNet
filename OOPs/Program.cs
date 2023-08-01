using Heritance;

//GPay gPay=new GPay();
//Paytm paytm=new Paytm(34,90);

PhonePe phonePe=new PhonePe(34000);
phonePe.available();
phonePe.transaction(5000);
phonePe.available();
phonePe.debiting(12000);
phonePe.available();