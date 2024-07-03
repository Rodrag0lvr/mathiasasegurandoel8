using org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Commands;

namespace org.higx.platform.u202210587.Hign.Assessment.Domain.Services;

public interface IMentalStateExamCommandService
{
    Task<MentalStateExam> Handle(CreateMentalStateExam command);

}