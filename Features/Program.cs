using Del;

Perform perform=new Perform();
search search1=new search(perform.linear);
search search2=new search(perform.binary);


// Console.WriteLine(search1(45));
// Console.WriteLine(search2(78));

find<int> find=new find<int>(perform.binary);
Console.WriteLine(find(45));

// using Gen;
// MyGenCap<float> cap1=new MyGenCap<float>(4.9f,2.3F);
// // cap1.alpha=4.9F;
// // cap1.gamma=2.3F;
// Console.WriteLine(cap1);

// MyGenCap<string> cap2=new MyGenCap<string>("Zealous","Mohamed");
// // cap2.alpha="Zealous";
// // cap2.gamma="Mohamed";
// Console.WriteLine(cap2);

// MyGenCouple<int,char> couple=new MyGenCouple<int, char>(78,'Z');
// Console.WriteLine(couple);
