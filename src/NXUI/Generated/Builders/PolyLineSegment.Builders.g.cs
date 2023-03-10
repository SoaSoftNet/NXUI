// <auto-generated />
namespace NXUI;

/// <summary>
/// The avalonia builders.
/// </summary>
public static partial class Builders
{
    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.PolyLineSegment"/> class.
    /// </summary>
    /// <returns>The new instance of the <see cref="Avalonia.Media.PolyLineSegment"/> class.</returns>
    public static Avalonia.Media.PolyLineSegment PolyLineSegment()
        => new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.PolyLineSegment"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.PolyLineSegment"/> instantiated class.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.PolyLineSegment"/> class.</returns>
    public static Avalonia.Media.PolyLineSegment PolyLineSegment(out Avalonia.Media.PolyLineSegment @ref)
        => @ref = new();

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.PolyLineSegment"/> class.
    /// </summary>
    /// <param name="points">The points value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.PolyLineSegment"/> class.</returns>
    public static Avalonia.Media.PolyLineSegment PolyLineSegment(System.Collections.Generic.IEnumerable<Avalonia.Point> points)
        => new(points);

    /// <summary>
    /// Creates a new instance of the <see cref="Avalonia.Media.PolyLineSegment"/> class.
    /// </summary>
    /// <param name="ref">The reference of the <see cref="Avalonia.Media.PolyLineSegment"/> instantiated class.</param>
    /// <param name="points">The points value.</param>
    /// <returns>The new instance of the <see cref="Avalonia.Media.PolyLineSegment"/> class.</returns>
    public static Avalonia.Media.PolyLineSegment PolyLineSegment(out Avalonia.Media.PolyLineSegment @ref, System.Collections.Generic.IEnumerable<Avalonia.Point> points)
        => @ref = new(points);
}
