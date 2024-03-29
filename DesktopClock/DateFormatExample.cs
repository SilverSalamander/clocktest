﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DesktopClock;

public record DateFormatExample
{
    private DateFormatExample(string format, string example)
    {
        Format = format;
        Example = example;
    }

    public string Format { get; }
    public string Example { get; }

    public static DateFormatExample Tutorial => new(string.Empty, "Create my own format...");

    /// <summary>
    /// Creates a <see cref="DateFormatExample" /> from the given format.
    /// </summary>
    public static DateFormatExample FromFormat(string format) => new(format, DateTimeOffset.Now.ToString(format));

    /// <summary>
    /// Common date time formatting strings and an example string for each.
    /// </summary>
    /// <remarks>https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings</remarks>
    public static IReadOnlyCollection<DateFormatExample> DefaultExamples { get; } = new[]
    {
        "M",
        "dddd, MMMM dd",
        "dddd, MMMM dd, HH:mm",
        "dddd, MMMM dd, h:mm tt",
        "dddd, MMM dd, HH:mm",
        "dddd, MMM dd, h:mm tt",
        "dddd, MMM dd, HH:mm:ss",
        "dddd, MMM dd, h:mm:ss tt",
        "ddd, MMM dd, HH:mm",
        "ddd, MMM dd, h:mm tt",
        "ddd, MMM dd, HH:mm:ss",
        "ddd, MMM dd, h:mm:ss tt",
        "ddd, MMM dd, HH:mm K",
        "ddd, MMM dd, h:mm tt K",
        "d",
        "g",
        "G",
        "t",
        "T",
        "O",
    }.Select(FromFormat).Append(Tutorial).ToList();
}