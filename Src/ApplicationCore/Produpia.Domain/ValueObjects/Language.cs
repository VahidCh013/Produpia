// <copyright file="Language.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using CSharpFunctionalExtensions;

namespace Produpia.Domain.ValueObjects;

public class Language : ValueObject
{
    private Language()
    {
    }

    private Language(string isoCode, string displayName)
    {
        ISOCode = isoCode;
        DisplayName = displayName;
    }

    public string ISOCode { get; }
    public string DisplayName { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return ISOCode;
        yield return ISOCode;
    }
}