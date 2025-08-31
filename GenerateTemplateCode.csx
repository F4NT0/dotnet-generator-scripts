using System;


void GenerateHelloWorld(string projectName)
{
    string code = $@"
      namespace {projectName}
      {{
        public class Program
        {{
          public static string GetHelloWorld()
          {{
            return ""Hello World!"";
          }}

          public static void Main(string[] args)
          {{
            string test = GetHelloWorld();
            Console.WriteLine(test);
          }}
        }}
       }}";

    File.WriteAllText($"{projectName}/Program.cs", code);
    Console.WriteLine("");
    Console.WriteLine(" \u001b[32m\u001b[0m Hello World Template created successfully!");
    Console.WriteLine("");
}


void GenerateTestCode(string projectName)
{
    string testProjectName = projectName + "Tests";
    string testCode = $@"
      using Microsoft.VisualStudio.TestTools.UnitTesting;
      using {projectName};

      namespace {testProjectName};

      [TestClass]
      public class UnitTest1
      {{
        [TestMethod]
        public void TestHelloWorld()
        {{
          string result = Program.GetHelloWorld();
          Assert.AreEqual(""Hello World!"", result);
        }}
      }}";

    File.WriteAllText($"{testProjectName}/Test1.cs", testCode);
    Console.WriteLine("");
    Console.WriteLine(" \u001b[32m\u001b[0m Hello World Test Template created successfully!");
    Console.WriteLine("");
}
