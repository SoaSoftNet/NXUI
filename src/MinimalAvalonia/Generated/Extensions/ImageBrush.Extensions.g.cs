// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ImageBrushExtensions
{
    // SourceProperty

    public static T Source<T>(this T obj, Avalonia.Media.Imaging.IBitmap value) where T : Avalonia.Media.ImageBrush
    {
        obj[Avalonia.Media.ImageBrush.SourceProperty] = value;
        return obj;
    }

    public static T Source<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.ImageBrush
    {
        obj[Avalonia.Media.ImageBrush.SourceProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Source<T>(this T obj, IObservable<Avalonia.Media.Imaging.IBitmap> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.ImageBrush
    {
        obj[Avalonia.Media.ImageBrush.SourceProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSource(this Avalonia.Media.ImageBrush obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.ImageBrush.SourceProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.Imaging.IBitmap> ObserveSource(this Avalonia.Media.ImageBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.ImageBrush.SourceProperty);
    }

    public static T OnSource<T>(this T obj, Action<IObservable<Avalonia.Media.Imaging.IBitmap>> handler) where T : Avalonia.Media.ImageBrush
    {
        var observable = obj.GetObservable(Avalonia.Media.ImageBrush.SourceProperty);
        handler(observable);
        return obj;
    }
}