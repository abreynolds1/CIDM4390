using System;

namespace Domain
{
    public interface IUnitOfWork : IDisposable
    {
         //ICourseRepository Course {get;}
         int Complete();
    }
}