// <copyright file="Book.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using Produpia.Domain.Common;
using Produpia.Domain.Entities.Authors;
using Produpia.Domain.Entities.Categories;
using Produpia.Domain.Entities.Publishers;
using Produpia.Domain.Enums;
using Produpia.Domain.ValueObjects;

namespace Produpia.Domain.Entities.Books;

public class Book : AggregateRoot, IDeletable, ITimeAudit
{
    protected readonly List<Author> _authors;

    private Book()
    {
    }

    private Book(string title, string description, int editionNumber, BookStatus status)
    {
        Title = title;
        Description = description;
        EditionNumber = editionNumber;
        Status = status;
        _authors = [];
    }

    protected IReadOnlyList<Author> Authors => _authors;
    public Publisher Publisher { get; }
    public int PageCount { get; }
    public Category Category { get; }
    public string Description { get; } = string.Empty;
    public DateTimeOffset PublicationDate { get; }
    public BookStatus Status { get; }
    public int EditionNumber { get; }
    public string Title { get; } = string.Empty;
    public ISBN Isbn { get; }
    public Price Price { get; }
    public Rights Rights { get; }
    public Language Language { get; }
    public bool IsDeleted { get; }
    public DateTimeOffset CreatedOn { get; }
    public DateTimeOffset ModifiedOn { get; }
}