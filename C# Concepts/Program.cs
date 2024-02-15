// See https://aka.ms/new-console-template for more information
using C__Concepts;

//Console.WriteLine("Hello, World!");
//Delegates obj = new Delegates();
//Call c1 = obj.Method1;
//Call c2 = obj.Method2;

//Console.WriteLine(typeof(c1));

// void newMethod(string a, string b, Call c)
//{
//    c(a + b);
//}

//newMethod("Tushar", "Badakh",c1);

//string a = "abc";
//string b = "ab";
//b += "c";

//Console.WriteLine(a==b);
//Console.WriteLine(a.Equals(b));

//Console.WriteLine(object.ReferenceEquals(a, b));
////Console.WriteLine(c1.Equals(c2));

//Console.WriteLine(c1.GetInvocationList().GetLength(0));

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string directoryPath = "D:\\OLD\\AngularUdemy";
        string folderName = "node_modules";

        DeleteFolder(directoryPath, folderName);
    }

    static void DeleteFolder(string directoryPath, string folderName)
    {
        string folderPath = Path.Combine(directoryPath, folderName);

        if (Directory.Exists(folderPath))
        {
            Console.WriteLine("Inside deletion");
            File.SetAttributes(folderPath, FileAttributes.Normal);
            Directory.Delete(folderPath, true);
            Console.WriteLine("Folder and its subfolders deleted successfully.");
        }
        else
        {
            Console.WriteLine("Folder does not exist in the directory.");
        }

        Console.WriteLine("Deleted");
    }
}

//Console.ReadLine();


//using System;
//using System.IO;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string sourceDirectoryPath = "D:\\OLD";
//        string destinationDirectoryPath = "C:\\Users\\Tushar.Badakh\\OneDrive - Nitor Infotech Pvt. Ltd\\D_DIrectory";
//        string excludedFolderName = "node_modules";

//        CopyFiles(sourceDirectoryPath, destinationDirectoryPath, excludedFolderName);
//    }

//    static void CopyFiles(string sourceDirectoryPath, string destinationDirectoryPath, string excludedFolderName)
//    {
//        DirectoryInfo sourceDirectory = new DirectoryInfo(sourceDirectoryPath);
//        DirectoryInfo destinationDirectory = new DirectoryInfo(destinationDirectoryPath);

//        if (!sourceDirectory.Exists)
//        {
//            Console.WriteLine("Source directory does not exist.");
//            return;
//        }

//        if (!destinationDirectory.Exists)
//        {
//            destinationDirectory.Create();
//        }

//        foreach (FileInfo file in sourceDirectory.GetFiles("*", SearchOption.AllDirectories))
//        {
//            Console.WriteLine("File Name : "+ file.DirectoryName);
//            if (file.Directory.Name.Contains(excludedFolderName))   
//            {
//                Console.WriteLine("Skiped : "+ file.DirectoryName);
//                continue; // Skip files inside the excluded folder and its subfolders
//            }
//            Console.WriteLine("Copied : " + excludedFolderName);
//            string destinationFilePath = file.FullName.Replace(sourceDirectory.FullName, destinationDirectory.FullName);
//            Directory.CreateDirectory(Path.GetDirectoryName(destinationFilePath));
//            file.CopyTo(destinationFilePath, true);
//        }

//        Console.WriteLine("Files copied successfully.");
//    }
//}