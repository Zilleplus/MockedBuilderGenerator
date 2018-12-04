using General.Contracts;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using System;
using System.Collections.Generic;
using System.Text;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CodeGenerator.Domain
{
    /// <summary>
    /// Builds a classBuilder
    /// </summary>
    public class ClassBuilderBuilder : IBuilder<SyntaxNode>
    {
        SyntaxGenerator _generator;
        string _className;
        List<SyntaxNode> _fields = new List<SyntaxNode>();
        
        public ClassBuilderBuilder()
        {
            _generator = SyntaxGenerator
                .GetGenerator(new AdhocWorkspace(), LanguageNames.CSharp);
        }

        public ClassBuilderBuilder WithProperty(
            string name, 
            string Type)
        {

            return this;
        }

            public ClassBuilderBuilder WithName(string name)
        {
            _className = name;

            return this;
        }

        public SyntaxNode Build()
        {
            return _generator.ClassDeclaration(_className+"Builder");
        }
    }
}
