// <copyright file="Author.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using Produpia.Domain.Common;
using Produpia.Domain.ValueObjects;

namespace Produpia.Domain.Entities.Authors;

public sealed class Author : EntityBase, IDeletable, ITimeAudit
{
    private Author()
    {
    }

    private Author(string firstName, string lastName, EmailAddress emailAddress)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string Biography { get; }
    public EmailAddress EmailAddress { get; }
    public DateTimeOffset? DateOfBirth { get; }
    public string Nationality { get; }

    public bool IsDeleted { get; }
    public DateTimeOffset CreatedOn { get; }
    public DateTimeOffset ModifiedOn { get; }
}