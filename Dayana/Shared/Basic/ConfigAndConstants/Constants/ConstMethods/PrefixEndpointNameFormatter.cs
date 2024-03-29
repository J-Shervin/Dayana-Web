﻿using MassTransit;
using System.Text.RegularExpressions;

namespace Dayana.Shared.Basic.ConfigAndConstants.Constants.ConstMethods;
public class PrefixEndpointNameFormatter : DefaultEndpointNameFormatter
{
    private static readonly Regex Pattern = new("(?<=[a-z0-9])[A-Z]", RegexOptions.Compiled);
    private readonly string _prefix;
    private readonly string _separator;

    public PrefixEndpointNameFormatter(string prefix, string separator = "-")
    {
        _prefix = prefix;
        _separator = separator;
    }

    public override string SanitizeName(string name)
    {
        return Pattern.Replace(_prefix + name, m => _separator + m.Value)
            .ToLowerInvariant();
    }
}