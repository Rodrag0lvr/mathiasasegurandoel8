using org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Commands;

namespace org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Aggregates;

public class MentalStateExam
{
    public long Id { get; set; }
    public long PatientId { get; set; }
    public string ExaminerNationalProviderIdentifier { get; set; }
    public DateTime ExamDate { get; set; }
    public int OrientationScore { get; set; }
    public int RegistrationScore { get; set; }
    public int AttentionAndCalculationScore { get; set; }
    public int RecallScore { get; set; }
    public int LanguageScore { get; set; }

    public MentalStateExam(CreateMentalStateExam command)
    {
        PatientId = command.PatientId;
        ExaminerNationalProviderIdentifier = command.ExaminerNationalProviderIdentifier;
        ExamDate = command.ExamDate;
        OrientationScore = command.OrientationScore;
        RegistrationScore = command.RegistrationScore;
        AttentionAndCalculationScore = command.AttentionAndCalculationScore;
        RecallScore = command.RecallScore;
        LanguageScore = command.LanguageScore;
    }

    public MentalStateExam(string examinerNationalProviderIdentifier)
    {
        ExaminerNationalProviderIdentifier = examinerNationalProviderIdentifier;
    }
}