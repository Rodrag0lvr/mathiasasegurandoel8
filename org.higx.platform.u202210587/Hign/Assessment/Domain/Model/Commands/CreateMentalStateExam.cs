namespace org.higx.platform.u202210587.Hign.Assessment.Domain.Model.Commands;

public record CreateMentalStateExam( long PatientId, String ExaminerNationalProviderIdentifier, DateTime ExamDate, int OrientationScore, int RegistrationScore, int AttentionAndCalculationScore, int RecallScore, int LanguageScore);