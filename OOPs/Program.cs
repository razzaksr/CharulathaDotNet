using Heritance;

Multiple multiple=new Multiple();
Console.WriteLine(multiple.binSearch("Flutter"));

// Warehouse warehouse=new Warehouse(10);
// do{
//     Console.WriteLine("Push\nPop\nRead\nUpdate\nView\nExit");
//     string option=Console.ReadLine();
//     switch(option){
//         case "push":case "PUSH":
//             Console.WriteLine("Tell us data to insert");
//             string data=Console.ReadLine();
//             warehouse.insert(data);
//             break;
//         case "pop":case "POP":
//             Console.WriteLine("Tell us data to remove");
//             String obj=Console.ReadLine();
//             Console.WriteLine(warehouse.deletion((object)obj));
//             break;
//         case "Read":case "read":
//             Console.WriteLine("Tell us index to read ");
//             int index=Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine(warehouse.readAt(index));
//             break;
//         case "Update":case "update":
//             Console.WriteLine("Tell data and position to update ");
//             string ob=Console.ReadLine();
//             int ind=Convert.ToInt32(Console.ReadLine());
//             warehouse.update((object)ob,ind);
//             break;
//         case "view":case "View":warehouse.listAll();break;
//         default:return;break;
//     }
// }while(true);