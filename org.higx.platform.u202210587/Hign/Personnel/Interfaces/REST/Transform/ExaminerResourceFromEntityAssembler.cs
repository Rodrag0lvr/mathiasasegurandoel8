using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Aggregates;
using org.higx.platform.u202210587.Hign.Personnel.Interfaces.REST.Resources;

namespace org.higx.platform.u202210587.Hign.Personnel.Interfaces.REST.Transform;

public static class ExaminerResourceFromEntityAssembler
{
    public static ExaminerResource ToResourceFromEntity(Examiner examiner)
    {
        return new ExaminerResource(examiner.id, examiner.firstName, examiner.lastName, examiner.nationalProviderIdentifier.ToString());
    }
}