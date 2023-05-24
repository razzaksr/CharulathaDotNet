using MyInputs;

MindBlow mindBlow=new MindBlow();// non literal object
Console.WriteLine(mindBlow.myOrg);

Stat stat=new Stat();
Console.WriteLine(stat.myOrg);
stat.switchOrg();
Console.WriteLine(stat.myOrg);
stat.quitJob();
Console.WriteLine(stat.myOrg);
stat.myOrg="IBM Corporation";
Console.WriteLine(stat.myOrg);

mindBlow.groot();