using Microsoft.CodeAnalysis;

namespace SafeRouting.Generator.Extensions;

public static class IncrementalValueProviderExtensions
{
  public static IncrementalValueProvider<bool> Not(
    this IncrementalValueProvider<bool> source
  ) => source.Select(static (x, _) => !x);
}
