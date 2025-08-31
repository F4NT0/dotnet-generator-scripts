using System;

void PrintBox(string text1, params string[] text2)
{

    int padding = 2;
    string content = $"│ >_ {text1} {string.Join(" ", text2)} ";
    int width = content.Length + padding;

    string top = "╭" + new string('─', width - 2) + "╮";
    string middle = content + new string(' ', width - content.Length - 1) + "│";
    string bottom = "╰" + new string('─', width - 2) + "╯";

    Console.WriteLine(top);
    Console.WriteLine(middle);
    Console.WriteLine(bottom);
}


void RunCommand(string name, params string[] args)
{
    Console.WriteLine("\nRunning the following command:\n");
    PrintBox(name, args);

    var process = new Process();
    process.StartInfo.FileName = name;
    process.StartInfo.Arguments = string.Join(" ", args);
    process.StartInfo.RedirectStandardOutput = false;
    process.StartInfo.RedirectStandardError = false;
    process.StartInfo.UseShellExecute = true;

    try
    {
        process.Start();
        process.WaitForExit();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n \u001b[31m \u001b[0m Error running command: {name} {string.Join(" ", args)}");
        Console.WriteLine($"{ex}");
        Environment.Exit(1);
    }
}
