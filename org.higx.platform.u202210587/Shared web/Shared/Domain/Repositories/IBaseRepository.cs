

namespace org.higx.platform.u202210587.Shared_web.Shared.Domain.Repositories;

public interface IBaseRepository<TEntity>
{
    Task AddAsync(TEntity entity);
    Task<TEntity> FindByIdAsync(int id);
}