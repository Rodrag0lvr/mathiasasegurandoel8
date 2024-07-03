using Microsoft.EntityFrameworkCore;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.ValueObjects;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Repositories;
using org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Configuration;
using org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace org.higx.platform.u202210587.Hign.Personnel.Infrastructure.Persistence.EFC.Repositories;

public class ExaminerRepository : BaseRepository<Examiner>, IExaminerRepository
{
    public ExaminerRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Examiner?> findByNationalIdentifier(NationalProviderIdentifier nationalProviderIdentifier)
    {
        return await Context.Examiners
            .Where(e => e.nationalProviderIdentifier.ToString() == nationalProviderIdentifier.ToString())
            .FirstOrDefaultAsync();
    }
}