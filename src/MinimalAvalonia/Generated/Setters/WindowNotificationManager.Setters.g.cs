// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class WindowNotificationManagerSetters
{
    // PositionProperty

    public static Style SetWindowNotificationManagerPosition(this Style style, Avalonia.Controls.Notifications.NotificationPosition value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, value));
        return style;
    }

    public static Style SetWindowNotificationManagerPosition(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding));
        return style;
    }

    public static Style SetWindowNotificationManagerPosition(this Style style, IObservable<Avalonia.Controls.Notifications.NotificationPosition> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetWindowNotificationManagerPosition(this KeyFrame keyFrame, Avalonia.Controls.Notifications.NotificationPosition value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetWindowNotificationManagerPosition(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetWindowNotificationManagerPosition(this KeyFrame keyFrame, IObservable<Avalonia.Controls.Notifications.NotificationPosition> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.PositionProperty, observable.ToBinding()));
        return keyFrame;
    }

    // MaxItemsProperty

    public static Style SetWindowNotificationManagerMaxItems(this Style style, System.Int32 value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, value));
        return style;
    }

    public static Style SetWindowNotificationManagerMaxItems(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding));
        return style;
    }

    public static Style SetWindowNotificationManagerMaxItems(this Style style, IObservable<System.Int32> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetWindowNotificationManagerMaxItems(this KeyFrame keyFrame, System.Int32 value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetWindowNotificationManagerMaxItems(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetWindowNotificationManagerMaxItems(this KeyFrame keyFrame, IObservable<System.Int32> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Notifications.WindowNotificationManager.MaxItemsProperty, observable.ToBinding()));
        return keyFrame;
    }
}