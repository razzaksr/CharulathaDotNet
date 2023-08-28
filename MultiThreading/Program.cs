// See https://aka.ms/new-console-template for more information
using MyThread;

WorkForce workForce=new WorkForce();
//workForce.findMinLossMaxProfit();

Thread thread1=new Thread(new ThreadStart(workForce.findMinLossMaxProfit));
Thread thread2=new Thread(new ThreadStart(workForce.findMinLossMaxProfit));
Thread thread3=new Thread(new ThreadStart(workForce.findMinLossMaxProfit));
Thread thread4=new Thread(new ThreadStart(workForce.findMinLossMaxProfit));
thread1.Start();
thread2.Start();
thread3.Start();
thread4.Start();

// Factor factor=new Factor();
// // factor.display();
// // factor.clock(2);

// Thread thread1=new Thread(new ThreadStart(factor.clock));
// thread1.Name="Vinayak";
// Thread thread2=new Thread(new ThreadStart(factor.clock));
// thread2.Name="Micheal";
// Thread thread3=new Thread(new ThreadStart(factor.clock));
// thread3.Name="Visak";
// Thread thread4=new Thread(new ThreadStart(factor.clock));
// thread4.Name="Balaji";
// thread1.Start();//thread1.Join();
// thread2.Start();
// thread3.Start();//thread3.Join();
// thread4.Start();
