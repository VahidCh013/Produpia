// <copyright file="ISBN.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using CSharpFunctionalExtensions;

namespace Produpia.Domain.ValueObjects;

public class ISBN : ValueObject
{
    protected ISBN()
    {
    }

    protected ISBN(string value)
    {
        Value = value;
    }

    public string Value { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}