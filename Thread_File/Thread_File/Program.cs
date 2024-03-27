
//Thread thread1 = new Thread(Method1);
//Thread thread2 = new Thread(Method2);

//thread1.Start();
//Method3();
//thread2.Start();
//Method4();

using Thread_File;
using Thread_File.Controllers;

//"/Users/fatimagaykhanova/Desktop/c#-filethreadtest/test1.txt"
//ExampleFile exampleFile = new ExampleFile();
//exampleFile.WriteToFile("/Users/fatimagaykhanova/Desktop/c#-filethreadtest/file2.txt","salam Fatya");
//exampleFile.WriteToFile("/Users/fatimagaykhanova/Desktop/c#-filethreadtest/file3.txt", "salam dunya ");
//exampleFile.ReaadFromFile("/Users/fatimagaykhanova/Desktop/c#-filethreadtest/file2.txt");
//exampleFile.WriteToNewFile("/Users/fatimagaykhanova/Desktop/c#-filethreadtest/file7.txt","Hello world I'm programmer");

FileController fileController = new FileController();
//await fileController.ReadDataAsync();
await fileController.CreateFileWithContentAsync();
//await fileController.DeleteAsync();