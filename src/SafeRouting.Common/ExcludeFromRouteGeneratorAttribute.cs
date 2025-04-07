using System;

namespace SafeRouting;

/// <summary>
/// Excludes the target from inclusion in generated routing code.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public sealed class ExcludeFromRouteGeneratorAttribute : Attribute
{
}
