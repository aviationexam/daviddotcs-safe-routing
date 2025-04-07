using System.Runtime.CompilerServices;
using VerifyTests;

namespace SafeRouting.Tests.Unit;

public static class ModuleInitializer
{
  [ModuleInitializer]
  public static void Init() => VerifySourceGenerators.Initialize();
}
