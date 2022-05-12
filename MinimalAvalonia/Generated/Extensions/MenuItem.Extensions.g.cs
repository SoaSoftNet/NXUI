// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class MenuItemExtensions
{
    // CommandProperty

    public static T Command<T>(this T obj, System.Windows.Input.ICommand value) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.CommandProperty] = value;
        return obj;
    }

    public static T Command<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.CommandProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Command<T>(this T obj, IObservable<System.Windows.Input.ICommand> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.CommandProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCommand(this Avalonia.Controls.MenuItem obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MenuItem.CommandProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Windows.Input.ICommand> ObserveCommand(this Avalonia.Controls.MenuItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.MenuItem.CommandProperty);
    }

    // IconProperty

    public static T Icon<T>(this T obj, System.Object value) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.IconProperty] = value;
        return obj;
    }

    public static T Icon<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.IconProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Icon<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.IconProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIcon(this Avalonia.Controls.MenuItem obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MenuItem.IconProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveIcon(this Avalonia.Controls.MenuItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.MenuItem.IconProperty);
    }

    // InputGestureProperty

    public static T InputGesture<T>(this T obj, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.InputGestureProperty] = value;
        return obj;
    }

    public static T InputGesture<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.InputGestureProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T InputGesture<T>(this T obj, IObservable<Avalonia.Input.KeyGesture> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.InputGestureProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindInputGesture(this Avalonia.Controls.MenuItem obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MenuItem.InputGestureProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Input.KeyGesture> ObserveInputGesture(this Avalonia.Controls.MenuItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.MenuItem.InputGestureProperty);
    }

    // IsSubMenuOpenProperty

    public static T IsSubMenuOpen<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.IsSubMenuOpenProperty] = value;
        return obj;
    }

    public static T IsSubMenuOpen<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.IsSubMenuOpenProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsSubMenuOpen<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.IsSubMenuOpenProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsSubMenuOpen(this Avalonia.Controls.MenuItem obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MenuItem.IsSubMenuOpenProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsSubMenuOpen(this Avalonia.Controls.MenuItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty);
    }

    // StaysOpenOnClickProperty

    public static T StaysOpenOnClick<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.StaysOpenOnClickProperty] = value;
        return obj;
    }

    public static T StaysOpenOnClick<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.StaysOpenOnClickProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T StaysOpenOnClick<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.MenuItem.StaysOpenOnClickProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindStaysOpenOnClick(this Avalonia.Controls.MenuItem obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MenuItem.StaysOpenOnClickProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveStaysOpenOnClick(this Avalonia.Controls.MenuItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty);
    }
}