using System;

namespace SimpleCore.Infrastructure.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}
