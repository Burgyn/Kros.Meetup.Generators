using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace Kros.Meetup
{
    internal class ToStringReceiver : ISyntaxReceiver
    {
        private static readonly string _attributeShort = "ToString";
        private readonly List<ClassDeclarationSyntax> _candidates = new List<ClassDeclarationSyntax>();

        public IEnumerable<ClassDeclarationSyntax> Candidates => _candidates;

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode is ClassDeclarationSyntax classSyntax && classSyntax.HaveAttribute(_attributeShort))
            {
                _candidates.Add(classSyntax);
            }
        }
    }
}