using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Commands;

namespace org.higx.platform.u202210587.Hign.Personnel.Domain.Services;

public interface IExaminerCommandService
{
    Task<Examiner> Handle(CreateExaminerCommand command);

}