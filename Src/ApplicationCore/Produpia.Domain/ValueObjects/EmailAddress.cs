// <copyright file="EmailAddress.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using CSharpFunctionalExtensions;

namespace Produpia.Domain.ValueObjects;

public sealed class EmailAddress : ValueObject
{
    private EmailAddress()
    {
    }

    private EmailAddress(string value)
    {
        Value = value;
    }


    public string Value { get; set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}