using org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Commands;

namespace org.higx.platform.u202210587.Hign.Assessment.Interfaces.REST.Transform;

public static class CreateMentalStateExamCommandFromResourceAssembler
{
    public static CreateMentalStateExam ToCommandFromResource(Resources.CreateMentalStateExamResource resource)
    {
        return new CreateMentalStateExam(resource.PatientId, resource.ExaminerNationalProviderIdentifier, resource.ExamDate, resource.OrientationScore, resource.RegistrationScore, resource.AttentionAndCalculationScore, resource.RecallScore, resource.LanguageScore);
    }

    
}