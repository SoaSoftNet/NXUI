// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.Pen"/> class property extension methods.
/// </summary>
public static partial class PenExtensions
{
    // Avalonia.Media.Pen.BrushProperty

    public static Avalonia.Media.Pen Brush(this Avalonia.Media.Pen obj, Avalonia.Media.IBrush value)
    {
        obj[Avalonia.Media.Pen.BrushProperty] = value;
        return obj;
    }

    public static Avalonia.Media.Pen Brush(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.BrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.Pen Brush(
        this Avalonia.Media.Pen obj,
        IObservable<Avalonia.Media.IBrush> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.BrushProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBrush(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.BrushProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveBrush(this Avalonia.Media.Pen obj)
    {
        return obj.GetObservable(Avalonia.Media.Pen.BrushProperty);
    }

    public static Avalonia.Media.Pen OnBrush(this Avalonia.Media.Pen obj, Action<Avalonia.Media.Pen, IObservable<Avalonia.Media.IBrush>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.Pen.BrushProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.Pen.ThicknessProperty

    public static Avalonia.Media.Pen Thickness(this Avalonia.Media.Pen obj, System.Double value)
    {
        obj[Avalonia.Media.Pen.ThicknessProperty] = value;
        return obj;
    }

    public static Avalonia.Media.Pen Thickness(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.ThicknessProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.Pen Thickness(
        this Avalonia.Media.Pen obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.ThicknessProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindThickness(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.ThicknessProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<System.Double> ObserveThickness(this Avalonia.Media.Pen obj)
    {
        return obj.GetObservable(Avalonia.Media.Pen.ThicknessProperty);
    }

    public static Avalonia.Media.Pen OnThickness(this Avalonia.Media.Pen obj, Action<Avalonia.Media.Pen, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.Pen.ThicknessProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.Pen.DashStyleProperty

    public static Avalonia.Media.Pen DashStyle(this Avalonia.Media.Pen obj, Avalonia.Media.IDashStyle value)
    {
        obj[Avalonia.Media.Pen.DashStyleProperty] = value;
        return obj;
    }

    public static Avalonia.Media.Pen DashStyle(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.DashStyleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.Pen DashStyle(
        this Avalonia.Media.Pen obj,
        IObservable<Avalonia.Media.IDashStyle> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.DashStyleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDashStyle(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.DashStyleProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.Media.IDashStyle> ObserveDashStyle(this Avalonia.Media.Pen obj)
    {
        return obj.GetObservable(Avalonia.Media.Pen.DashStyleProperty);
    }

    public static Avalonia.Media.Pen OnDashStyle(this Avalonia.Media.Pen obj, Action<Avalonia.Media.Pen, IObservable<Avalonia.Media.IDashStyle>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.Pen.DashStyleProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.Pen.LineCapProperty

    public static Avalonia.Media.Pen LineCap(this Avalonia.Media.Pen obj, Avalonia.Media.PenLineCap value)
    {
        obj[Avalonia.Media.Pen.LineCapProperty] = value;
        return obj;
    }

    public static Avalonia.Media.Pen LineCap(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.LineCapProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.Pen LineCap(
        this Avalonia.Media.Pen obj,
        IObservable<Avalonia.Media.PenLineCap> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.LineCapProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindLineCap(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.LineCapProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.Media.PenLineCap> ObserveLineCap(this Avalonia.Media.Pen obj)
    {
        return obj.GetObservable(Avalonia.Media.Pen.LineCapProperty);
    }

    public static Avalonia.Media.Pen OnLineCap(this Avalonia.Media.Pen obj, Action<Avalonia.Media.Pen, IObservable<Avalonia.Media.PenLineCap>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.Pen.LineCapProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.Pen.LineCapProperty"/> property value to <see cref="Avalonia.Media.PenLineCap.Flat"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.Pen LineCapFlat(this Avalonia.Media.Pen obj)
    {
        obj[Avalonia.Media.Pen.LineCapProperty] = Avalonia.Media.PenLineCap.Flat;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.Pen.LineCapProperty"/> property value to <see cref="Avalonia.Media.PenLineCap.Round"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.Pen LineCapRound(this Avalonia.Media.Pen obj)
    {
        obj[Avalonia.Media.Pen.LineCapProperty] = Avalonia.Media.PenLineCap.Round;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.Pen.LineCapProperty"/> property value to <see cref="Avalonia.Media.PenLineCap.Square"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.Pen LineCapSquare(this Avalonia.Media.Pen obj)
    {
        obj[Avalonia.Media.Pen.LineCapProperty] = Avalonia.Media.PenLineCap.Square;
        return obj;
    }

    // Avalonia.Media.Pen.LineJoinProperty

    public static Avalonia.Media.Pen LineJoin(this Avalonia.Media.Pen obj, Avalonia.Media.PenLineJoin value)
    {
        obj[Avalonia.Media.Pen.LineJoinProperty] = value;
        return obj;
    }

    public static Avalonia.Media.Pen LineJoin(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.LineJoinProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.Pen LineJoin(
        this Avalonia.Media.Pen obj,
        IObservable<Avalonia.Media.PenLineJoin> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.LineJoinProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindLineJoin(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.LineJoinProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.Media.PenLineJoin> ObserveLineJoin(this Avalonia.Media.Pen obj)
    {
        return obj.GetObservable(Avalonia.Media.Pen.LineJoinProperty);
    }

    public static Avalonia.Media.Pen OnLineJoin(this Avalonia.Media.Pen obj, Action<Avalonia.Media.Pen, IObservable<Avalonia.Media.PenLineJoin>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.Pen.LineJoinProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.Pen.LineJoinProperty"/> property value to <see cref="Avalonia.Media.PenLineJoin.Bevel"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.Pen LineJoinBevel(this Avalonia.Media.Pen obj)
    {
        obj[Avalonia.Media.Pen.LineJoinProperty] = Avalonia.Media.PenLineJoin.Bevel;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.Pen.LineJoinProperty"/> property value to <see cref="Avalonia.Media.PenLineJoin.Miter"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.Pen LineJoinMiter(this Avalonia.Media.Pen obj)
    {
        obj[Avalonia.Media.Pen.LineJoinProperty] = Avalonia.Media.PenLineJoin.Miter;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Media.Pen.LineJoinProperty"/> property value to <see cref="Avalonia.Media.PenLineJoin.Round"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Media.Pen LineJoinRound(this Avalonia.Media.Pen obj)
    {
        obj[Avalonia.Media.Pen.LineJoinProperty] = Avalonia.Media.PenLineJoin.Round;
        return obj;
    }

    // Avalonia.Media.Pen.MiterLimitProperty

    public static Avalonia.Media.Pen MiterLimit(this Avalonia.Media.Pen obj, System.Double value)
    {
        obj[Avalonia.Media.Pen.MiterLimitProperty] = value;
        return obj;
    }

    public static Avalonia.Media.Pen MiterLimit(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.MiterLimitProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.Pen MiterLimit(
        this Avalonia.Media.Pen obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.MiterLimitProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMiterLimit(
        this Avalonia.Media.Pen obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.Pen.MiterLimitProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<System.Double> ObserveMiterLimit(this Avalonia.Media.Pen obj)
    {
        return obj.GetObservable(Avalonia.Media.Pen.MiterLimitProperty);
    }

    public static Avalonia.Media.Pen OnMiterLimit(this Avalonia.Media.Pen obj, Action<Avalonia.Media.Pen, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.Pen.MiterLimitProperty);
        handler(obj, observable);
        return obj;
    }
}
