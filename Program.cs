using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace AddressBookFileIO
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("File IO with Address Book :");
            FileExists();
            ReadAllLines();
            WriteUsingStreamWriter();

        }

        public static void FileExists()
        {
            String path = @"E:\dotnet\DataStructure\AddressBookFileIO\TextFile1.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesn't exists");


        }

        public static void ReadAllLines()
        {
            String path = @"E:\dotnet\DataStructure\AddressBookFileIO\TextFile1.txt";
            String[] lines;
         
            lines = File.ReadAllLines(path);

            foreach(var text in lines)
            {
              Console.WriteLine(text);
            }
            Console.WriteLine("Suucessfully read from Textfile1");

        }

        public static void WriteUsingStreamWriter()
        {
            String path = @"E:\dotnet\DataStructure\AddressBookFileIO\TextFile1.txt";
            
            Console.WriteLine("---------------------------------------");

            using (StreamWriter sr = File.AppendText(path))
            {
              sr.WriteLine("First Name : Ash");
              sr.WriteLine("Last Name  : Dream");
              sr.WriteLine("Address    : xyz street");
              sr.WriteLine("City       : chikisha");
              sr.WriteLine("State      : Oklohoma");
              sr.WriteLine("Zip        : 1234");
              sr.WriteLine("Phone Number: 345 - 4889789");
              sr.WriteLine("Email      :  Ash.d@gmail.com");
              sr.WriteLine("---------------------------------------");
               
              
 

                sr.Close();
                Console.WriteLine("Sucessfully written into Textfile1");
                Console.WriteLine("Content of TextFile1 :");
               
                Console.WriteLine(File.ReadAllText(path));
            }

            
            
        }

    }

}