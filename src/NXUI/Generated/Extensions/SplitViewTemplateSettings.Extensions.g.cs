// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.SplitViewTemplateSettings"/> class property extension methods.
/// </summary>
public static partial class SplitViewTemplateSettingsExtensions
{
    // Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ClosedPaneWidth<T>(this T obj, System.Double value) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        obj[Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ClosedPaneWidth<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        var descriptor = Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ClosedPaneWidth<T>(
        this T obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        var descriptor = Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindClosedPaneWidth(
        this Avalonia.Controls.SplitViewTemplateSettings obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Double> ObserveClosedPaneWidth(this Avalonia.Controls.SplitViewTemplateSettings obj)
    {
        return obj.GetObservable(Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnClosedPaneWidth<T>(this T obj, Action<Avalonia.Controls.SplitViewTemplateSettings, IObservable<System.Double>> handler) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        var observable = obj.GetObservable(Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PaneColumnGridLength<T>(this T obj, Avalonia.Controls.GridLength value) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        obj[Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PaneColumnGridLength<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        var descriptor = Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T PaneColumnGridLength<T>(
        this T obj,
        IObservable<Avalonia.Controls.GridLength> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        var descriptor = Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindPaneColumnGridLength(
        this Avalonia.Controls.SplitViewTemplateSettings obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Controls.GridLength> ObservePaneColumnGridLength(this Avalonia.Controls.SplitViewTemplateSettings obj)
    {
        return obj.GetObservable(Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnPaneColumnGridLength<T>(this T obj, Action<Avalonia.Controls.SplitViewTemplateSettings, IObservable<Avalonia.Controls.GridLength>> handler) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        var observable = obj.GetObservable(Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty);
        handler(obj, observable);
        return obj;
    }
}
