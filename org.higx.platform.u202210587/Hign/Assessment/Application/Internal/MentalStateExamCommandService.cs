using org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Commands;
using org.higx.platform.u202210587.Hign.Assessment.Domain.Repositories;
using org.higx.platform.u202210587.Hign.Assessment.Domain.Services;
using org.higx.platform.u202210587.Shared_web.Shared.Domain.Repositories;
using org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace org.higx.platform.u202210587.Hign.Assessment.Application.Internal;

public class MentalStateExamCommandService: IMentalStateExamCommandService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMentalRepository _mentalRepository;
    public MentalStateExamCommandService( IMentalRepository mentalRepository, IUnitOfWork unitOfWork) 
    {
        _mentalRepository = mentalRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<MentalStateExam> Handle(CreateMentalStateExam command)
    {
        var mentalStateExam = new MentalStateExam(command);
        await _mentalRepository.AddAsync(mentalStateExam);
        await _unitOfWork.CompleteAsync();
        return mentalStateExam;
    }


}