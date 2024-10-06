using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        Password password1 = new Password();

        Console.WriteLine("Set a password for your journal:");
        string password = Console.ReadLine();
        password1.SetThePassword(password);


        bool running = true;

        while(running)
        {   
            Console.WriteLine("Enter your password");
            string enteredpassword = Console.ReadLine();
            
            if(password1.CheckPassword(enteredpassword))
            {
                Console.WriteLine("Welcome to your Journal.");
            }
            else
            {
                Console.WriteLine("Wrong Password, Try again.");
                continue;
            }
            

            Console.WriteLine("Please select one of the following choices:"); 
            Console.WriteLine("1.-Write");  
            Console.WriteLine("2.-Display");  
            Console.WriteLine("3.-Save");  
            Console.WriteLine("4.-Load");  
            Console.WriteLine("5.-Quit");  
            Console.WriteLine("What would you like to do?");  
            
            string choice = Console.ReadLine();

            if (choice == "1")
            { 
                string randomPrompt = promptGenerator.GetRandomPrompt(); 
                Console.WriteLine(randomPrompt);

                Console.WriteLine("");
                string _entryText = Console.ReadLine();
                journal.AddEntry(randomPrompt,_entryText);
                Console.WriteLine("Entry added!");
            }
            else if (choice == "2")
            {
                journal.DisplayAllEntries();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter the file name");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
                Console.WriteLine($"Journal saved in {fileName}");
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
                journal.DisplayAllEntries();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the journal!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again please.");
            }
        }
    }
}