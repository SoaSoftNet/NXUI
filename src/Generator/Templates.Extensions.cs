﻿using System.Diagnostics.CodeAnalysis;

namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
internal static partial class Templates
{
    public static string PropertyMethodEnumTemplate = @"
    public static T %Name%%EnumValue%<T>(this T obj) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property] = %ValueType%.%EnumValue%;
        return obj;
    }";

    public static string PropertyMethodEnumSealedTemplate = @"
    public static %OwnerType% %Name%%EnumValue%(this %OwnerType% obj)
    {
        obj[%ClassType%.%Name%Property] = %ValueType%.%EnumValue%;
        return obj;
    }";

    public static string PropertyMethodsTemplate = @"    // %Name%Property

    public static T %Name%<T>(this T obj, %ValueType% value) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property] = value;
        return obj;
    }

    public static T %Name%<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T %Name%<T>(this T obj, IObservable<%ValueType%> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : %OwnerType%
    {
        obj[%ClassType%.%Name%Property.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding Bind%Name%(this %OwnerType% obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[%ClassType%.%Name%Property.Bind().WithMode(mode)];
    }

    public static IObservable<%ValueType%> Observe%Name%(this %OwnerType% obj)
    {
        return obj.GetObservable(%ClassType%.%Name%Property);
    }

    public static T On%Name%<T>(this T obj, Action<%OwnerType%, IObservable<%ValueType%>> handler) where T : %OwnerType%
    {
        var observable = obj.GetObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }";

    public static string PropertyMethodsTemplateSealed = @"    // %Name%Property

    public static %OwnerType% %Name%(this %OwnerType% obj, %ValueType% value)
    {
        obj[%ClassType%.%Name%Property] = value;
        return obj;
    }

    public static %OwnerType% %Name%(this %OwnerType% obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[%ClassType%.%Name%Property.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static %OwnerType% %Name%(this %OwnerType% obj, IObservable<%ValueType%> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[%ClassType%.%Name%Property.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding Bind%Name%(this %OwnerType% obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[%ClassType%.%Name%Property.Bind().WithMode(mode)];
    }

    public static IObservable<%ValueType%> Observe%Name%(this %OwnerType% obj)
    {
        return obj.GetObservable(%OwnerType%.%Name%Property);
    }

    public static %OwnerType% On%Name%(this %OwnerType% obj, Action<%OwnerType%, IObservable<%ValueType%>> handler)
    {
        var observable = obj.GetObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }";

    public static string PropertyMethodsTemplateReadOnly = @"    // %Name%Property

    public static Avalonia.Data.IBinding Bind%Name%(this %OwnerType% obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[%ClassType%.%Name%Property.Bind().WithMode(mode)];
    }

    public static IObservable<%ValueType%> Observe%Name%(this %OwnerType% obj)
    {
        return obj.GetObservable(%ClassType%.%Name%Property);
    }

    public static %OwnerType% On%Name%(this %OwnerType% obj, Action<%OwnerType%, IObservable<%ValueType%>> handler)
    {
        var observable = obj.GetObservable(%ClassType%.%Name%Property);
        handler(obj, observable);
        return obj;
    }";
}