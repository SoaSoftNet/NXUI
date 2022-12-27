// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.QuadraticBezierSegment"/> class property extension methods.
/// </summary>
public static partial class QuadraticBezierSegmentExtensions
{
    // Avalonia.Media.QuadraticBezierSegment.Point1Property

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.QuadraticBezierSegment.Point1Property"/> value on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.QuadraticBezierSegment Point1(this Avalonia.Media.QuadraticBezierSegment obj, Avalonia.Point value)
    {
        obj[Avalonia.Media.QuadraticBezierSegment.Point1Property] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.QuadraticBezierSegment.Point1Property"/> on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.QuadraticBezierSegment Point1(
        this Avalonia.Media.QuadraticBezierSegment obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point1Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.QuadraticBezierSegment.Point1Property"/> on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.QuadraticBezierSegment Point1(
        this Avalonia.Media.QuadraticBezierSegment obj,
        IObservable<Avalonia.Point> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point1Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.QuadraticBezierSegment.Point1Property"/> binding on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.QuadraticBezierSegment.Point1Property"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPoint1(
        this Avalonia.Media.QuadraticBezierSegment obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point1Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.QuadraticBezierSegment.Point1Property"/> on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Point> ObservePoint1(this Avalonia.Media.QuadraticBezierSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.QuadraticBezierSegment.Point1Property);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.QuadraticBezierSegment.Point1Property"/> property on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.QuadraticBezierSegment OnPoint1(this Avalonia.Media.QuadraticBezierSegment obj, Action<Avalonia.Media.QuadraticBezierSegment, IObservable<Avalonia.Point>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.QuadraticBezierSegment.Point1Property);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.QuadraticBezierSegment.Point2Property

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.QuadraticBezierSegment.Point2Property"/> value on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value to set for the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.QuadraticBezierSegment Point2(this Avalonia.Media.QuadraticBezierSegment obj, Avalonia.Point value)
    {
        obj[Avalonia.Media.QuadraticBezierSegment.Point2Property] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.QuadraticBezierSegment.Point2Property"/> on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/> with a source binding specified as a parameter.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.QuadraticBezierSegment Point2(
        this Avalonia.Media.QuadraticBezierSegment obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point2Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Media.QuadraticBezierSegment.Point2Property"/> on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/> with a source binding specified as an observable.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.QuadraticBezierSegment Point2(
        this Avalonia.Media.QuadraticBezierSegment obj,
        IObservable<Avalonia.Point> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point2Property.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Media.QuadraticBezierSegment.Point2Property"/> binding on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Media.QuadraticBezierSegment.Point2Property"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPoint2(
        this Avalonia.Media.QuadraticBezierSegment obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.QuadraticBezierSegment.Point2Property.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Media.QuadraticBezierSegment.Point2Property"/> on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the object, and thereafter whenever the property changes.
    /// </returns>
    public static IObservable<Avalonia.Point> ObservePoint2(this Avalonia.Media.QuadraticBezierSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.QuadraticBezierSegment.Point2Property);
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Media.QuadraticBezierSegment.Point2Property"/> property on an object of type <see cref="Avalonia.Media.QuadraticBezierSegment"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the property changes.</param>
    /// <returns>The target object.</returns>
    public static Avalonia.Media.QuadraticBezierSegment OnPoint2(this Avalonia.Media.QuadraticBezierSegment obj, Action<Avalonia.Media.QuadraticBezierSegment, IObservable<Avalonia.Point>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.QuadraticBezierSegment.Point2Property);
        handler(obj, observable);
        return obj;
    }
}
