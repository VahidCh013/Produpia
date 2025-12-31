// <copyright file="Price.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using CSharpFunctionalExtensions;

namespace Produpia.Domain.ValueObjects;

public class Price : ValueObject
{
    protected Price()
    {
    }

    protected Price(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public decimal Amount { get; }
    public string Currency { get; }


    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }
}