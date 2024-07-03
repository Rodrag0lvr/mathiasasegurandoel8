using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Commands;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.ValueObjects;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Repositories;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Services;
using org.higx.platform.u202210587.Shared_web.Shared.Domain.Repositories;

namespace org.higx.platform.u202210587.Hign.Personnel.Application.Internal;

public class ExaminerCommandService : IExaminerCommandService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IExaminerRepository _examinerRepository;

    public ExaminerCommandService(IExaminerRepository examinerRepository, IUnitOfWork unitOfWork)
    {
        _examinerRepository = examinerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Examiner> Handle(CreateExaminerCommand command)
    {
        Examiner examiner = new Examiner(command);
        await _examinerRepository.AddAsync(examiner);

        // Commit changes with the unit of work
        await _unitOfWork.CompleteAsync();

        return examiner;
    }
}