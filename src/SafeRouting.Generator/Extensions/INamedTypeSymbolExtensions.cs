using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace SafeRouting.Generator.Extensions;

internal static class INamedTypeSymbolExtensions
{
  public static IEnumerable<INamedTypeSymbol> EnumerateSelfAndBaseTypes(this INamedTypeSymbol symbol)
  {
    var current = symbol;
    while (current != null)
    {
      yield return current;

      current = current.BaseType;
    }
  }
}
