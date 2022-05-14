// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TimePickerPresenterExtensions
{
    // MinuteIncrementProperty

    public static T MinuteIncrement<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty] = value;
        return obj;
    }

    public static T MinuteIncrement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MinuteIncrement<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMinuteIncrement(this Avalonia.Controls.TimePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveMinuteIncrement(this Avalonia.Controls.TimePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty);
    }

    public static T OnMinuteIncrement<T>(this T obj, Action<IObservable<System.Int32>> handler) where T : Avalonia.Controls.TimePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty);
        handler(observable);
        return obj;
    }

    // ClockIdentifierProperty

    public static T ClockIdentifier<T>(this T obj, System.String value) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty] = value;
        return obj;
    }

    public static T ClockIdentifier<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ClockIdentifier<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindClockIdentifier(this Avalonia.Controls.TimePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveClockIdentifier(this Avalonia.Controls.TimePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty);
    }

    public static T OnClockIdentifier<T>(this T obj, Action<IObservable<System.String>> handler) where T : Avalonia.Controls.TimePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty);
        handler(observable);
        return obj;
    }

    // TimeProperty

    public static T Time<T>(this T obj, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.TimeProperty] = value;
        return obj;
    }

    public static T Time<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.TimeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Time<T>(this T obj, IObservable<System.TimeSpan> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TimePickerPresenter
    {
        obj[Avalonia.Controls.TimePickerPresenter.TimeProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTime(this Avalonia.Controls.TimePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TimePickerPresenter.TimeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.TimeSpan> ObserveTime(this Avalonia.Controls.TimePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.TimePickerPresenter.TimeProperty);
    }

    public static T OnTime<T>(this T obj, Action<IObservable<System.TimeSpan>> handler) where T : Avalonia.Controls.TimePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.TimePickerPresenter.TimeProperty);
        handler(observable);
        return obj;
    }
}