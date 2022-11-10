// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.DrawingImage"/> class property extension methods.
/// </summary>
public static partial class DrawingImageExtensions
{
    // Avalonia.Media.DrawingImage.DrawingProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Drawing<T>(this T obj, Avalonia.Media.Drawing value) where T : Avalonia.Media.DrawingImage
    {
        obj[Avalonia.Media.DrawingImage.DrawingProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Drawing<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.DrawingImage
    {
        var descriptor = Avalonia.Media.DrawingImage.DrawingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Drawing<T>(
        this T obj,
        IObservable<Avalonia.Media.Drawing> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Media.DrawingImage
    {
        var descriptor = Avalonia.Media.DrawingImage.DrawingProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindDrawing(
        this Avalonia.Media.DrawingImage obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.DrawingImage.DrawingProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Media.Drawing> ObserveDrawing(this Avalonia.Media.DrawingImage obj)
    {
        return obj.GetObservable(Avalonia.Media.DrawingImage.DrawingProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Media.DrawingImage.DrawingProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnDrawing<T>(this T obj, Action<Avalonia.Media.DrawingImage, IObservable<Avalonia.Media.Drawing>> handler) where T : Avalonia.Media.DrawingImage
    {
        var observable = obj.GetObservable(Avalonia.Media.DrawingImage.DrawingProperty);
        handler(obj, observable);
        return obj;
    }
}