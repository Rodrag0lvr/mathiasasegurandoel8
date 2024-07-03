using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.ValueObjects;
using org.higx.platform.u202210587.Shared_web.Shared.Domain.Repositories;

namespace org.higx.platform.u202210587.Hign.Personnel.Domain.Repositories;

public interface IExaminerRepository: IBaseRepository<Examiner>
{
    Task<Examiner?> findByNationalIdentifier(NationalProviderIdentifier nationalProviderIdentifier);    
}