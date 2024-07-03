using org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Assessment.Interfaces.REST.Resources;
using org.higx.platform.u202210587.Hign.Personnel.Interfaces.REST.Resources;

namespace org.higx.platform.u202210587.Hign.Assessment.Interfaces.REST.Transform;

public static class MentalStateExamResourceFromEntityAssembler
{
    public static MentalStateExamResource  ToResourceFromEntity(MentalStateExam mental)
    {
        /*long id, long PatientId, String ExaminerNationalProviderIdentifier, DateTime ExamDate, int OrientationScore, int RegistrationScore, int AttentionAndCalculationScore, int RecallScore, int LanguageScore*/
        return new MentalStateExamResource( mental.Id, mental.PatientId, mental.ExaminerNationalProviderIdentifier, mental.ExamDate, mental.OrientationScore, mental.RegistrationScore, mental.AttentionAndCalculationScore, mental.RecallScore, mental.LanguageScore);
        
    }
}