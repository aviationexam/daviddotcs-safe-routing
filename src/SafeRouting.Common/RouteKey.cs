namespace SafeRouting;

/// <summary>
/// Represents a strongly-typed key within a route.
/// </summary>
/// <typeparam name="TScope">A type representing the scope in which the key is valid.</typeparam>
/// <typeparam name="TValue">The type of values which can be used with this key.</typeparam>
public sealed class RouteKey<TScope, TValue>
{
  /// <summary>
  /// Creates a route key with the specified name.
  /// </summary>
  /// <param name="name">The name of the key.</param>
  public RouteKey(string name)
  {
    Name = name;
  }

  /// <summary>
  /// The name of the key.
  /// </summary>
  public string Name { get; }
}
