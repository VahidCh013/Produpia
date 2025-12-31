// <copyright file="Dimensions.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using CSharpFunctionalExtensions;

namespace Produpia.Domain.ValueObjects;

public sealed class Dimensions : ValueObject
{
    private Dimensions()
    {
    }

    private Dimensions(decimal height, decimal width, decimal thickness)
    {
        Height = height;
        Width = width;
        Thickness = thickness;
    }

    public decimal Height { get; }
    public decimal Width { get; }
    public decimal Thickness { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Height;
        yield return Width;
        yield return Thickness;
    }
}