// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class RotateTransformExtensions
{
    // AngleProperty

    public static T Angle<T>(this T obj, System.Double value) where T : Avalonia.Media.RotateTransform
    {
        obj[Avalonia.Media.RotateTransform.AngleProperty] = value;
        return obj;
    }

    public static T Angle<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.RotateTransform
    {
        obj[Avalonia.Media.RotateTransform.AngleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Angle<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.RotateTransform
    {
        obj[Avalonia.Media.RotateTransform.AngleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAngle(this Avalonia.Media.RotateTransform obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.RotateTransform.AngleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveAngle(this Avalonia.Media.RotateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.RotateTransform.AngleProperty);
    }

    // CenterXProperty

    public static T CenterX<T>(this T obj, System.Double value) where T : Avalonia.Media.RotateTransform
    {
        obj[Avalonia.Media.RotateTransform.CenterXProperty] = value;
        return obj;
    }

    public static T CenterX<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.RotateTransform
    {
        obj[Avalonia.Media.RotateTransform.CenterXProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T CenterX<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.RotateTransform
    {
        obj[Avalonia.Media.RotateTransform.CenterXProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCenterX(this Avalonia.Media.RotateTransform obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.RotateTransform.CenterXProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveCenterX(this Avalonia.Media.RotateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.RotateTransform.CenterXProperty);
    }

    // CenterYProperty

    public static T CenterY<T>(this T obj, System.Double value) where T : Avalonia.Media.RotateTransform
    {
        obj[Avalonia.Media.RotateTransform.CenterYProperty] = value;
        return obj;
    }

    public static T CenterY<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.RotateTransform
    {
        obj[Avalonia.Media.RotateTransform.CenterYProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T CenterY<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.RotateTransform
    {
        obj[Avalonia.Media.RotateTransform.CenterYProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCenterY(this Avalonia.Media.RotateTransform obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.RotateTransform.CenterYProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveCenterY(this Avalonia.Media.RotateTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.RotateTransform.CenterYProperty);
    }
}