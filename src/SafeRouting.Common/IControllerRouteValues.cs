using Microsoft.AspNetCore.Mvc;

namespace SafeRouting;

/// <summary>
/// Represents route values for a <see cref="Controller"/>'s action method.
/// </summary>
public interface IControllerRouteValues : IRouteValues
{
  /// <summary>
  /// The name of the controller.
  /// </summary>
  string ControllerName { get; }

  /// <summary>
  /// The name of the action method.
  /// </summary>
  string ActionName { get; }
}
