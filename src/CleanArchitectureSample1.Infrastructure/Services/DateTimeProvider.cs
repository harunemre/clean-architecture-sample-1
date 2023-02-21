using CleanArchitectureSample1.Application.Common.Interfaces.Services;

namespace CleanArchitectureSample1.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}