﻿using System.Diagnostics.CodeAnalysis;

namespace Generator;

[SuppressMessage("ReSharper", "InconsistentNaming")]
internal static partial class Templates
{
    public static string BuildersHeaderTemplate = @"namespace MinimalAvalonia;

public static partial class MinimalAvaloniaBuilders
{";

    public static string BuildersFooterTemplate = @"}";
}
