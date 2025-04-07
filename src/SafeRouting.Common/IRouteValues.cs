using Microsoft.AspNetCore.Routing;

namespace SafeRouting;

/// <summary>
/// Represents route values for an arbitrary route.
/// </summary>
public interface IRouteValues
{
  /// <summary>
  /// A collection of key/value pairs for the route.
  /// </summary>
  RouteValueDictionary RouteValues { get; }
}
