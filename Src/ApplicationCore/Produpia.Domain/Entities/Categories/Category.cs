// <copyright file="Category.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using Produpia.Domain.Common;

namespace Produpia.Domain.Entities.Categories;

public sealed class Category :EntityBase, IDeletable, ITimeAudit
{
    private Category()
    {
    }

    public string Name { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }

    public bool IsDeleted { get; private set; }
    public DateTimeOffset CreatedOn { get; private set; }
    public DateTimeOffset ModifiedOn { get; private set; }
}