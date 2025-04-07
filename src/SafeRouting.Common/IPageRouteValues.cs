using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SafeRouting;

/// <summary>
/// Represents route values for a <see cref="PageModel"/>'s handler method.
/// </summary>
public interface IPageRouteValues : IRouteValues
{
  /// <summary>
  /// The name of the page.
  /// </summary>
  string PageName { get; }

  /// <summary>
  /// The name of the handler.
  /// </summary>
  string? HandlerName { get; }
}
