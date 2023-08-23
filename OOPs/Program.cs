using Heritance;

// Backend backend=new Backend();
// Backend backend=Backend.GetBackend();
// Console.WriteLine(backend.getArrSize());
// backend=Backend.GetBackend(30);
// Console.WriteLine(backend.getArrSize());

// backend.insert(45);

//Component component=new Component();
Mark mark=new Mark();
mark.traverse();
mark.binary("Node",0,mark.arr.Length-1);
mark.binary("React",0,mark.arr.Length-1);