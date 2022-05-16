// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SelectingItemsControlExtensions
{
    // AutoScrollToSelectedItemProperty

    public static T AutoScrollToSelectedItem<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty] = value;
        return obj;
    }

    public static T AutoScrollToSelectedItem<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T AutoScrollToSelectedItem<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAutoScrollToSelectedItem(this Avalonia.Controls.Primitives.SelectingItemsControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveAutoScrollToSelectedItem(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty);
    }

    public static T OnAutoScrollToSelectedItem<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty);
        handler(obj, observable);
        return obj;
    }

    // SelectedIndexProperty

    public static T SelectedIndex<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty] = value;
        return obj;
    }

    public static T SelectedIndex<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedIndex<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedIndex(this Avalonia.Controls.Primitives.SelectingItemsControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveSelectedIndex(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty);
    }

    public static T OnSelectedIndex<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Int32>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty);
        handler(obj, observable);
        return obj;
    }

    // SelectedItemProperty

    public static T SelectedItem<T>(this T obj, System.Object value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty] = value;
        return obj;
    }

    public static T SelectedItem<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedItem<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedItem(this Avalonia.Controls.Primitives.SelectingItemsControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveSelectedItem(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty);
    }

    public static T OnSelectedItem<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Object>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty);
        handler(obj, observable);
        return obj;
    }

    // IsTextSearchEnabledProperty

    public static T IsTextSearchEnabled<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty] = value;
        return obj;
    }

    public static T IsTextSearchEnabled<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsTextSearchEnabled<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsTextSearchEnabled(this Avalonia.Controls.Primitives.SelectingItemsControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsTextSearchEnabled(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty);
    }

    public static T OnIsTextSearchEnabled<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty);
        handler(obj, observable);
        return obj;
    }

    // WrapSelectionProperty

    public static T WrapSelection<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty] = value;
        return obj;
    }

    public static T WrapSelection<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T WrapSelection<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj[Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindWrapSelection(this Avalonia.Controls.Primitives.SelectingItemsControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveWrapSelection(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty);
    }

    public static T OnWrapSelection<T>(this T obj, Action<Avalonia.Controls.Primitives.SelectingItemsControl, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty);
        handler(obj, observable);
        return obj;
    }

    // IsSelectedChangedEvent

    public static T OnIsSelectedChangedHandler<T>(this T obj, Action<T, Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj.AddHandler(Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static T OnIsSelectedChanged<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.IsSelectedChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    // public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIsSelectedChanged(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    // {
    //     return Observable
    //         .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
    //             h => obj.IsSelectedChanged += h, 
    //             h => obj.IsSelectedChanged -= h)
    //         .Select(x => x.EventArgs);
    // }

    // SelectionChangedEvent

    public static T OnSelectionChangedHandler<T>(this T obj, Action<T, Avalonia.Controls.SelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        obj.AddHandler(Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static T OnSelectionChanged<T>(this T obj, Action<T, IObservable<Avalonia.Controls.SelectionChangedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.SelectingItemsControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.SelectingItemsControl.SelectionChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Controls.SelectionChangedEventArgs> ObserveOnSelectionChanged(this Avalonia.Controls.Primitives.SelectingItemsControl obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.SelectionChangedEventArgs>, Avalonia.Controls.SelectionChangedEventArgs>(
                h => obj.SelectionChanged += h, 
                h => obj.SelectionChanged -= h)
            .Select(x => x.EventArgs);
    }
}
