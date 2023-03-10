// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.NativeMenuItemBase"/> class property extension methods.
/// </summary>
public static partial class NativeMenuItemBaseExtensions
{
    // Avalonia.Controls.NativeMenuItemBase.ParentProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.NativeMenuItemBase.ParentProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Parent<T>(this T obj, Avalonia.Controls.NativeMenu value) where T : Avalonia.Controls.NativeMenuItemBase
    {
        obj[Avalonia.Controls.NativeMenuItemBase.ParentProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenuItemBase.ParentProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Parent<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.NativeMenuItemBase
    {
        var descriptor = Avalonia.Controls.NativeMenuItemBase.ParentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.NativeMenuItemBase.ParentProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Parent<T>(
        this T obj,
        IObservable<Avalonia.Controls.NativeMenu> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.NativeMenuItemBase
    {
        var descriptor = Avalonia.Controls.NativeMenuItemBase.ParentProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.NativeMenuItemBase.ParentProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.NativeMenuItemBase.ParentProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindParent(
        this Avalonia.Controls.NativeMenuItemBase obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.NativeMenuItemBase.ParentProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.NativeMenuItemBase.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.NativeMenu> ObserveParent(this Avalonia.Controls.NativeMenuItemBase obj)
    {
        return obj.GetObservable(Avalonia.Controls.NativeMenuItemBase.ParentProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.NativeMenuItemBase.ParentProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnParent<T>(this T obj, Action<Avalonia.Controls.NativeMenuItemBase, IObservable<Avalonia.Controls.NativeMenu>> handler) where T : Avalonia.Controls.NativeMenuItemBase
    {
        var observable = obj.GetObservable(Avalonia.Controls.NativeMenuItemBase.ParentProperty);
        handler(obj, observable);
        return obj;
    }
}
