// <copyright file="Publisher.cs">
// Copyright (c) 2025 All Rights Reserved
// </copyright>

using Produpia.Domain.Common;
using Produpia.Domain.ValueObjects;

namespace Produpia.Domain.Entities.Publishers;

public sealed class Publisher : EntityBase, IDeletable, ITimeAudit
{
    private Publisher()
    {
    }

    private Publisher(string name, string country, EmailAddress emailAddress)
    {
        Name = name;
        Country = country;
        EmailAddress = emailAddress;
    }

    public string Name { get; private set; }
    public string Country { get; private set; }
    public EmailAddress EmailAddress { get; private set; }
    public bool IsDeleted { get; }
    public DateTimeOffset CreatedOn { get; }
    public DateTimeOffset ModifiedOn { get; }
}