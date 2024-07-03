namespace org.higx.platform.u202210587.Hign.Assessment.Interfaces.REST.Resources;

public record CreateMentalStateExamResource( long PatientId, String ExaminerNationalProviderIdentifier, DateTime ExamDate, int OrientationScore, int RegistrationScore, int AttentionAndCalculationScore, int RecallScore, int LanguageScore);