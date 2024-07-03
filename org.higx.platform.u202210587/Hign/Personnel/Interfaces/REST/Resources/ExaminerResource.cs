using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.ValueObjects;

namespace org.higx.platform.u202210587.Hign.Personnel.Interfaces.REST.Resources;

public record ExaminerResource(long id, string firstName, string lastName, string nationalProviderIdentifier);