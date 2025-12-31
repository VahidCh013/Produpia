// <copyright file="EntityBase.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using CSharpFunctionalExtensions;

namespace Produpia.Domain.Common;

public abstract class EntityBase:Entity<ulong>
{
    protected EntityBase()
    {
        
    }
    protected EntityBase(ulong id) : base(id)
    {
    }
}