#load "messages.csx"
#load "ConsoleProjectGen.csx"
#load "GenerateTemplateCode.csx"
#load "DotnetBasicCommands.csx"
#load "GeneralMethods.csx"
#r "System.Console"

using System;

// Intro Message
HelloIntro();

// 1. Create a Solution to run the project and tests
Console.Write("-> 1. Enter the Solution name (Ex: SolutionExample): ");
Console.Write("");
string solutionName = Console.ReadLine()?.Trim();
if (string.IsNullOrWhiteSpace(solutionName)){
  Console.WriteLine("\u001b[31m  Invalid solution name. Please try again.\u001b[0m");
  Environment.Exit(1);
}
CreateSolution(solutionName);

// -> 2. Create Console Project
Console.Write("-> 2. Enter the Project name (Ex: ProjectExample): ");
Console.Write("");
string projName = Console.ReadLine()?.Trim();
if (string.IsNullOrWhiteSpace(projName)){
  Console.WriteLine("\u001b[31m  Invalid Project name. Please try again.\u001b[0m");
  Environment.Exit(1);
}
CreateProject(projName);

// -> 3. Create Test Project
Console.WriteLine($"-> 3. Creating the Test Project from {projName}...");
CreateTestProject(projName);

// -> 4. Add Project and Test Project into the Solution
Console.WriteLine($"-> 4. Configuring the {projName} and {projName}Tests into Solution...");
ConfigureProjects(projName);

// -> 5. Configure the project into the test project
Console.WriteLine($"-> 5. Configuring the {projName} reference inside the {projName}Tests...");
ConfigureProjOnTest(projName);

// -> 6 Hello World to Program.cs of the project.
Console.WriteLine($"-> 6. Creating the Hello World template...");
GenerateHelloWorld(projName);

// -> 7. Hello World to Test Program.cs.
Console.WriteLine($"-> 7. Creating the Test Hello World template...");
GenerateTestCode(projName);

// -> 8. Running the project.
Console.WriteLine($"-> 8. Running the Project...");
RunProject(projName);

// -> 9. Running the test project.
Console.WriteLine($"-> 9. Running the Test Project...");
RunTestProject(projName);

// -> 10. End of the creation.
EndConsoleProjectMessage();
