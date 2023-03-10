// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.FlyoutBase"/> class property extension methods.
/// </summary>
public static partial class FlyoutBaseExtensions
{
    // Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsOpen(
        this Avalonia.Controls.Primitives.FlyoutBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsOpen(this Avalonia.Controls.Primitives.FlyoutBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.FlyoutBase OnIsOpen(this Avalonia.Controls.Primitives.FlyoutBase obj, Action<Avalonia.Controls.Primitives.FlyoutBase, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.IsOpenProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.FlyoutBase.TargetProperty

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.FlyoutBase.TargetProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.FlyoutBase.TargetProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindTarget(
        this Avalonia.Controls.Primitives.FlyoutBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.TargetProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.TargetProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Control> ObserveTarget(this Avalonia.Controls.Primitives.FlyoutBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.TargetProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.TargetProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <returns>The target object reference.</returns>
    public static Avalonia.Controls.Primitives.FlyoutBase OnTarget(this Avalonia.Controls.Primitives.FlyoutBase obj, Action<Avalonia.Controls.Primitives.FlyoutBase, IObservable<Avalonia.Controls.Control>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.TargetProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Placement<T>(this T obj, Avalonia.Controls.FlyoutPlacementMode value) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Placement<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Placement<T>(
        this T obj,
        IObservable<Avalonia.Controls.FlyoutPlacementMode> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPlacement(
        this Avalonia.Controls.Primitives.FlyoutBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.FlyoutPlacementMode> ObservePlacement(this Avalonia.Controls.Primitives.FlyoutBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPlacement<T>(this T obj, Action<Avalonia.Controls.Primitives.FlyoutBase, IObservable<Avalonia.Controls.FlyoutPlacementMode>> handler) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.Top"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementTop<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.Top;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.Bottom"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementBottom<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.Bottom;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.Left"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.Left;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.Right"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementRight<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.Right;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.TopEdgeAlignedLeft"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementTopEdgeAlignedLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.TopEdgeAlignedLeft;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.TopEdgeAlignedRight"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementTopEdgeAlignedRight<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.TopEdgeAlignedRight;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.BottomEdgeAlignedLeft"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementBottomEdgeAlignedLeft<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.BottomEdgeAlignedLeft;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.BottomEdgeAlignedRight"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementBottomEdgeAlignedRight<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.BottomEdgeAlignedRight;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.LeftEdgeAlignedTop"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementLeftEdgeAlignedTop<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.LeftEdgeAlignedTop;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.LeftEdgeAlignedBottom"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementLeftEdgeAlignedBottom<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.LeftEdgeAlignedBottom;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.RightEdgeAlignedTop"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementRightEdgeAlignedTop<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.RightEdgeAlignedTop;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.RightEdgeAlignedBottom"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementRightEdgeAlignedBottom<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.RightEdgeAlignedBottom;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty"/> property value to <see cref="Avalonia.Controls.FlyoutPlacementMode.Auto"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PlacementAuto<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.PlacementProperty] = Avalonia.Controls.FlyoutPlacementMode.Auto;
        return obj;
    }

    // Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowMode<T>(this T obj, Avalonia.Controls.FlyoutShowMode value) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowMode<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowMode<T>(
        this T obj,
        IObservable<Avalonia.Controls.FlyoutShowMode> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindShowMode(
        this Avalonia.Controls.Primitives.FlyoutBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.FlyoutShowMode> ObserveShowMode(this Avalonia.Controls.Primitives.FlyoutBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnShowMode<T>(this T obj, Action<Avalonia.Controls.Primitives.FlyoutBase, IObservable<Avalonia.Controls.FlyoutShowMode>> handler) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/> property value to <see cref="Avalonia.Controls.FlyoutShowMode.Standard"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowModeStandard<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty] = Avalonia.Controls.FlyoutShowMode.Standard;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/> property value to <see cref="Avalonia.Controls.FlyoutShowMode.Transient"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowModeTransient<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty] = Avalonia.Controls.FlyoutShowMode.Transient;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty"/> property value to <see cref="Avalonia.Controls.FlyoutShowMode.TransientWithDismissOnPointerMoveAway"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ShowModeTransientWithDismissOnPointerMoveAway<T>(this T obj) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.ShowModeProperty] = Avalonia.Controls.FlyoutShowMode.TransientWithDismissOnPointerMoveAway;
        return obj;
    }

    // Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OverlayInputPassThroughElement<T>(this T obj, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OverlayInputPassThroughElement<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OverlayInputPassThroughElement<T>(
        this T obj,
        IObservable<Avalonia.Input.IInputElement> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindOverlayInputPassThroughElement(
        this Avalonia.Controls.Primitives.FlyoutBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Input.IInputElement> ObserveOverlayInputPassThroughElement(this Avalonia.Controls.Primitives.FlyoutBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnOverlayInputPassThroughElement<T>(this T obj, Action<Avalonia.Controls.Primitives.FlyoutBase, IObservable<Avalonia.Input.IInputElement>> handler) where T : Avalonia.Controls.Primitives.FlyoutBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.OverlayInputPassThroughElementProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AttachedFlyout<T>(this T obj, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AttachedFlyout<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T AttachedFlyout<T>(
        this T obj,
        IObservable<Avalonia.Controls.Primitives.FlyoutBase> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Control
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindAttachedFlyout(
        this Avalonia.Controls.Control obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.Primitives.FlyoutBase> ObserveAttachedFlyout(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnAttachedFlyout<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Controls.Primitives.FlyoutBase>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.FlyoutBase.AttachedFlyoutProperty);
        handler(obj, observable);
        return obj;
    }
}
