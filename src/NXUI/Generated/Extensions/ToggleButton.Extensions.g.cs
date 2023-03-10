// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The avalonia <see cref="Avalonia.Controls.Primitives.ToggleButton"/> class property extension methods.
/// </summary>
public static partial class ToggleButtonExtensions
{
    // Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsChecked<T>(this T obj, System.Nullable<System.Boolean> value) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsChecked<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsChecked<T>(
        this T obj,
        IObservable<System.Nullable<System.Boolean>> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsChecked(
        this Avalonia.Controls.Primitives.ToggleButton obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Nullable<System.Boolean>> ObserveIsChecked(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsChecked<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<System.Nullable<System.Boolean>>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsThreeState<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsThreeState<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsThreeState<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsThreeState(
        this Avalonia.Controls.Primitives.ToggleButton obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsThreeState(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsThreeState<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.Primitives.ToggleButton.CheckedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.ToggleButton.CheckedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnCheckedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj.AddHandler(Avalonia.Controls.Primitives.ToggleButton.CheckedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.ToggleButton.CheckedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnChecked<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.CheckedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Primitives.ToggleButton.CheckedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnChecked(
        this Avalonia.Controls.Primitives.ToggleButton obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.CheckedEvent, routes);
    }

    // Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnUncheckedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj.AddHandler(Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnUnchecked<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnUnchecked(
        this Avalonia.Controls.Primitives.ToggleButton obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent, routes);
    }

    // Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="action">The action to be performed when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnIndeterminateHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj.AddHandler(Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    /// <summary>
    /// Registers a handler for the <see cref="Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/> and returns an observable for the event.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object.</returns>
    public static T OnIndeterminate<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent, routes);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Gets an observable for the <see cref="Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent"/> event on an object of type <see cref="Avalonia.Controls.Primitives.ToggleButton"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="routes">The routing strategies for the event.</param>
    /// <returns>An observable for the event.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIndeterminate(
        this Avalonia.Controls.Primitives.ToggleButton obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent, routes);
    }

    // Avalonia.Controls.Primitives.ToggleButton.Checked

    /// <summary>
    /// Adds a handler to the `Checked` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnCheckedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Checked += h, 
                h => obj.Checked -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Checked` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Checked` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnCheckedEvent(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Checked += h, 
                h => obj.Checked -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.Primitives.ToggleButton.Unchecked

    /// <summary>
    /// Adds a handler to the `Unchecked` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnUncheckedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Unchecked += h, 
                h => obj.Unchecked -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Unchecked` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Unchecked` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnUncheckedEvent(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Unchecked += h, 
                h => obj.Unchecked -= h)
            .Select(x => x.EventArgs);
    }

    // Avalonia.Controls.Primitives.ToggleButton.Indeterminate

    /// <summary>
    /// Adds a handler to the `Indeterminate` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler to be called when the event is raised.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIndeterminateEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Indeterminate += h, 
                h => obj.Indeterminate -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    /// <summary>
    /// Returns an observable for the `Indeterminate` event on the specified object.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>An observable for the `Indeterminate` event on the specified object.</returns>
    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIndeterminateEvent(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Indeterminate += h, 
                h => obj.Indeterminate -= h)
            .Select(x => x.EventArgs);
    }
}
