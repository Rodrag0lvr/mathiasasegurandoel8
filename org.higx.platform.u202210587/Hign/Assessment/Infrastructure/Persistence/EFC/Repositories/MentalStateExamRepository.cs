using org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Assessment.Domain.Repositories;
using org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Configuration;
using org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace org.higx.platform.u202210587.Hign.Assessment.Infrastructure.Persistence.EFC.Repositories;

public class MentalStateExamRepository : BaseRepository<MentalStateExam>,IMentalRepository
{
    
    public MentalStateExamRepository(AppDbContext context) : base(context)
    {
    }
    
}