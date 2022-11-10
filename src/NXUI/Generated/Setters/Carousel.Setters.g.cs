// <auto-generated />
namespace NXUI.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.Carousel"/> class style setters extension methods.
/// </summary>
public static partial class CarouselSetters
{
    // Avalonia.Controls.Carousel.IsVirtualizedProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Carousel.IsVirtualizedProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetCarouselIsVirtualized(this Style style, System.Boolean value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Carousel.IsVirtualizedProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Carousel.IsVirtualizedProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetCarouselIsVirtualized(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Carousel.IsVirtualizedProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Carousel.IsVirtualizedProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetCarouselIsVirtualized(this Style style, IObservable<System.Boolean> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Carousel.IsVirtualizedProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Carousel.IsVirtualizedProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetCarouselIsVirtualized(this KeyFrame keyFrame, System.Boolean value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Carousel.IsVirtualizedProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Carousel.IsVirtualizedProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetCarouselIsVirtualized(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Carousel.IsVirtualizedProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Carousel.IsVirtualizedProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetCarouselIsVirtualized(this KeyFrame keyFrame, IObservable<System.Boolean> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Carousel.IsVirtualizedProperty, observable.ToBinding()));
        return keyFrame;
    }

    // Avalonia.Controls.Carousel.PageTransitionProperty

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Carousel.PageTransitionProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetCarouselPageTransition(this Style style, Avalonia.Animation.IPageTransition value)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Carousel.PageTransitionProperty, value));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Carousel.PageTransitionProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetCarouselPageTransition(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Carousel.PageTransitionProperty, binding));
        return style;
    }

    /// <summary>
    /// Adds a style setter for an <see cref="Avalonia.Controls.Carousel.PageTransitionProperty"/>.
    /// </summary>
    /// <param name="style">The target style.</param>
    /// <param name="observable">The property observable.</param>
    /// <returns>The target style object reference.</returns>
    public static Style SetCarouselPageTransition(this Style style, IObservable<Avalonia.Animation.IPageTransition> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Controls.Carousel.PageTransitionProperty, observable.ToBinding()));
        return style;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Carousel.PageTransitionProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="value">The property value.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetCarouselPageTransition(this KeyFrame keyFrame, Avalonia.Animation.IPageTransition value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Carousel.PageTransitionProperty, value));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Carousel.PageTransitionProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="binding">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetCarouselPageTransition(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Carousel.PageTransitionProperty, binding));
        return keyFrame;
    }

    /// <summary>
    /// Adds a keyframe setter for an <see cref="Avalonia.Controls.Carousel.PageTransitionProperty"/>.
    /// </summary>
    /// <param name="keyFrame">The target keyframe.</param>
    /// <param name="observable">The property binding.</param>
    /// <returns>The target keyframe object reference.</returns>
    public static KeyFrame SetCarouselPageTransition(this KeyFrame keyFrame, IObservable<Avalonia.Animation.IPageTransition> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Controls.Carousel.PageTransitionProperty, observable.ToBinding()));
        return keyFrame;
    }
}