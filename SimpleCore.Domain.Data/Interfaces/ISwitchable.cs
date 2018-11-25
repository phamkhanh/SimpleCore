using SimpleCore.Infrastructure.Enums;

namespace SimpleCore.Domain.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}