#r "System.Console"

using System;

void HelloIntro()
{
    Console.WriteLine("\u001b[35m");
    Console.WriteLine(@"
        _____           _           _      _____                           _              
       |  __ \         (_)         | |    / ____|                         | |             
       | |__) | __ ___  _  ___  ___| |_  | |  __  ___ _ __   ___ _ __ __ _| |_ ___  _ __  
       |  ___/ '__/ _ \| |/ _ \/ __| __| | | |_ |/ _ \ '_ \ / _ \ '__/ _` | __/ _ \| '__| 
       | |   | | | (_) | |  __/ (__| |_  | |__| |  __/ | | |  __/ | | (_| | || (_) | |    
       |_|   |_|  \___/| |\___|\___|\__|  \_____|\___|_| |_|\___|_|  \__,_|\__\___/|_|    
                      _/ |                                                                
                     |__/                                                                 
    ");
    Console.WriteLine("\u001b[0m");
}

void EndConsoleProjectMessage()
{
  Console.WriteLine("");
  Console.WriteLine("\u001b[32m┌──────────────────────────────────────┐\u001b[0m");
	Console.WriteLine("\u001b[32m│ CONSOLE PROJECT GENERATION COMPLETE! │\u001b[0m");
	Console.WriteLine("\u001b[32m└──────────────────────────────────────┘\u001b[0m");
	Console.WriteLine("");
  Console.WriteLine("Thank you for using this script! Please give a \u001b[33m\u001b[0m on my Repository!");
	Console.WriteLine("-> https://www.github.com/F4NT0/dotnet-generator-scripts");
	Console.WriteLine("");
}


