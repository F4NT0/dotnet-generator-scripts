#load "GeneralMethods.csx"

using System;

void RunProject(string projName)
{
    string csProjPath = $"{projName}/{projName}.csproj";
    RunCommand("dotnet", "run", "--project", csProjPath);
    Console.WriteLine("");
    Console.WriteLine(" \u001b[32m\u001b[0m Project run successfully!");
    Console.WriteLine("");
}

void RunTestProject(string projName)
{

    string testProjName = projName + "Tests";
    string csprojPath = $"{testProjName}/{testProjName}.csproj";
    RunCommand("dotnet", "test", csprojPath);
    Console.WriteLine("");
    Console.WriteLine(" \u001b[32m\u001b[0m Test Project run successfully!");
    Console.WriteLine("");
}
