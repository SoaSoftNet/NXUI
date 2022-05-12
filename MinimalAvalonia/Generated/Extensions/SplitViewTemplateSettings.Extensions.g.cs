// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SplitViewTemplateSettingsExtensions
{
    // ClosedPaneWidthProperty

    public static T ClosedPaneWidth<T>(this T obj, System.Double value) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        obj[Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty] = value;
        return obj;
    }

    public static T ClosedPaneWidth<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        obj[Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ClosedPaneWidth<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        obj[Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindClosedPaneWidth(this Avalonia.Controls.SplitViewTemplateSettings obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveClosedPaneWidth(this Avalonia.Controls.SplitViewTemplateSettings obj)
    {
        return obj.GetObservable(Avalonia.Controls.SplitViewTemplateSettings.ClosedPaneWidthProperty);
    }

    // PaneColumnGridLengthProperty

    public static T PaneColumnGridLength<T>(this T obj, Avalonia.Controls.GridLength value) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        obj[Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty] = value;
        return obj;
    }

    public static T PaneColumnGridLength<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        obj[Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T PaneColumnGridLength<T>(this T obj, IObservable<Avalonia.Controls.GridLength> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitViewTemplateSettings
    {
        obj[Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPaneColumnGridLength(this Avalonia.Controls.SplitViewTemplateSettings obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.GridLength> ObservePaneColumnGridLength(this Avalonia.Controls.SplitViewTemplateSettings obj)
    {
        return obj.GetObservable(Avalonia.Controls.SplitViewTemplateSettings.PaneColumnGridLengthProperty);
    }
}