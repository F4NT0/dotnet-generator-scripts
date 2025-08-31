#load "GeneralMethods.csx"

using System;

void CreateSolution(string solName)
{
    try
    {
        Directory.CreateDirectory(solName);
    }
    catch (Exception ex)
    {
        Console.WriteLine($" \u001b[31m\u001b[0m Failed to create folder: {solName}");
        Console.WriteLine($"Error: {ex}");
        Environment.Exit(1);
    }

    try
    {
        Directory.SetCurrentDirectory(solName);
    }
    catch (Exception ex)
    {
        Console.WriteLine($" \u001b[31m\u001b[0m Failed to enter folder: {solName}");
        Console.WriteLine($"Error: {ex}");
        Environment.Exit(1);
    }

    RunCommand("dotnet", "new", "sln", "--name", solName);
    Console.WriteLine("");
    Console.WriteLine(" \u001b[32m\u001b[0m Solution created successfully!");
    Console.WriteLine("");
}

void CreateProject(string projName)
{
    try
    {
        RunCommand("dotnet", "new", "console", "-o", projName);
        Console.WriteLine("");
        Console.WriteLine(" \u001b[32m\u001b[0m Project created successfully!");
        Console.WriteLine("");
    }
    catch (Exception ex)
    {
        Console.WriteLine($" \u001b[31m\u001b[0m Failed to create Project: {projName}");
        Console.WriteLine($"Error: {ex}");
        Environment.Exit(1);
    }
}

void CreateTestProject(string projName)
{

    string testProjName = projName + "Tests";
    try
    {
        RunCommand("dotnet", "new", "mstest", "-o", testProjName);
        Console.WriteLine("");
        Console.WriteLine(" \u001b[32m\u001b[0m Test Project created successfully!");
        Console.WriteLine("");
    }
    catch (Exception ex)
    {
        Console.WriteLine($" \u001b[31m\u001b[0m Failed to create Test Project: {testProjName}");
        Console.WriteLine($"Error: {ex}");
        Environment.Exit(1);
    }
}

void ConfigureProjects(string projName)
{
    string testProjName = projName + "Tests";
    string csprojProject = $"{projName}/{projName}.csproj";
    string csprojTest = $"{testProjName}/{testProjName}.csproj";

    try
    {

        RunCommand("dotnet", "sln", "add", csprojProject);
        Console.WriteLine("");
        Console.WriteLine("\u001b[32m  \u001b[0m Project configured into the Solution successfully!");
        Console.WriteLine("");

        RunCommand("dotnet", "sln", "add", csprojTest);
        Console.WriteLine("");
        Console.WriteLine("\u001b[32m  \u001b[0m Test Project configured into the Solution successfully!");
        Console.WriteLine("");
    }
    catch (Exception ex)
    {
        Console.WriteLine($" \u001b[31m\u001b[0m Failed to add projects into the Solution!");
        Console.WriteLine($"Error: {ex}");
        Environment.Exit(1);

    }
}

void ConfigureProjOnTest(string projName)
{
    try
    {

        string testProjName = projName + "Tests";
        string csprojProject = $"{projName}/{projName}.csproj";
        string csprojTest = $"{testProjName}/{testProjName}.csproj";

        RunCommand("dotnet", "add", csprojTest, "reference", csprojProject);
        Console.WriteLine("");
        Console.WriteLine("\u001b[32m  \u001b[0m Added Project reference into the Test Project successfully!");
        Console.WriteLine("");  
    }
    catch (Exception ex)
    {
        Console.WriteLine($" \u001b[31m\u001b[0m Failed to configure the Project into the Test Project!");
        Console.WriteLine($"Error: {ex}");
        Environment.Exit(1);

    }
}

