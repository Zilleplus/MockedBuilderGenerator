using Microsoft.CodeAnalysis;
using System;
using Microsoft.CodeAnalysis.Editing;
using CodeGenerator.Domain;

namespace Demo
{

    public class Program
    {
        static string demoClass = @"";
        static void Main(string[] args)
        {


            var workspace = new AdhocWorkspace();
            var generator = SyntaxGenerator.GetGenerator(workspace, LanguageNames.CSharp);

            var testClass = new ClassBuilderBuilder()
                .WithName("TestClass")
                .Build();

            var namespaceDeclaration = generator.NamespaceDeclaration("MyTypes", testClass);
            var usingDirectives = generator.NamespaceImportDeclaration("System");

            var newNode = generator.CompilationUnit(usingDirectives, namespaceDeclaration).
                NormalizeWhitespace();

            Console.WriteLine(newNode);
        }
    }
}
