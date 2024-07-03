
namespace org.higx.platform.u202210587.Shared_web.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}