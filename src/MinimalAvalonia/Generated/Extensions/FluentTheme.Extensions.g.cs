// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Themes.Fluent.FluentTheme"/> class property extension methods.
/// </summary>
public static partial class FluentThemeExtensions
{
    // Avalonia.Themes.Fluent.FluentTheme.ModeProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Mode<T>(this T obj, Avalonia.Themes.Fluent.FluentThemeMode value) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        obj[Avalonia.Themes.Fluent.FluentTheme.ModeProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Mode<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        var descriptor = Avalonia.Themes.Fluent.FluentTheme.ModeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T Mode<T>(
        this T obj,
        IObservable<Avalonia.Themes.Fluent.FluentThemeMode> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        var descriptor = Avalonia.Themes.Fluent.FluentTheme.ModeProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindMode(
        this Avalonia.Themes.Fluent.FluentTheme obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Themes.Fluent.FluentTheme.ModeProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Themes.Fluent.FluentThemeMode> ObserveMode(this Avalonia.Themes.Fluent.FluentTheme obj)
    {
        return obj.GetObservable(Avalonia.Themes.Fluent.FluentTheme.ModeProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnMode<T>(this T obj, Action<Avalonia.Themes.Fluent.FluentTheme, IObservable<Avalonia.Themes.Fluent.FluentThemeMode>> handler) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        var observable = obj.GetObservable(Avalonia.Themes.Fluent.FluentTheme.ModeProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/> property value to <see cref="Avalonia.Themes.Fluent.FluentThemeMode.Light"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ModeLight<T>(this T obj) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        obj[Avalonia.Themes.Fluent.FluentTheme.ModeProperty] = Avalonia.Themes.Fluent.FluentThemeMode.Light;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Themes.Fluent.FluentTheme.ModeProperty"/> property value to <see cref="Avalonia.Themes.Fluent.FluentThemeMode.Dark"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T ModeDark<T>(this T obj) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        obj[Avalonia.Themes.Fluent.FluentTheme.ModeProperty] = Avalonia.Themes.Fluent.FluentThemeMode.Dark;
        return obj;
    }

    // Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DensityStyle<T>(this T obj, Avalonia.Themes.Fluent.DensityStyle value) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        obj[Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DensityStyle<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        var descriptor = Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DensityStyle<T>(
        this T obj,
        IObservable<Avalonia.Themes.Fluent.DensityStyle> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        var descriptor = Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindDensityStyle(
        this Avalonia.Themes.Fluent.FluentTheme obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<Avalonia.Themes.Fluent.DensityStyle> ObserveDensityStyle(this Avalonia.Themes.Fluent.FluentTheme obj)
    {
        return obj.GetObservable(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnDensityStyle<T>(this T obj, Action<Avalonia.Themes.Fluent.FluentTheme, IObservable<Avalonia.Themes.Fluent.DensityStyle>> handler) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        var observable = obj.GetObservable(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/> property value to <see cref="Avalonia.Themes.Fluent.DensityStyle.Normal"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DensityStyleNormal<T>(this T obj) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        obj[Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty] = Avalonia.Themes.Fluent.DensityStyle.Normal;
        return obj;
    }

    /// <summary>
    /// Sets a <see cref="Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty"/> property value to <see cref="Avalonia.Themes.Fluent.DensityStyle.Compact"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T DensityStyleCompact<T>(this T obj) where T : Avalonia.Themes.Fluent.FluentTheme
    {
        obj[Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty] = Avalonia.Themes.Fluent.DensityStyle.Compact;
        return obj;
    }
}
