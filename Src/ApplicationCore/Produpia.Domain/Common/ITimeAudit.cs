namespace Produpia.Domain.Common;

public interface ITimeAudit
{
    public DateTimeOffset CreatedOn { get; }
    public DateTimeOffset ModifiedOn { get; }
}