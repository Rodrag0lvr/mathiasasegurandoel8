using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Commands;
using org.higx.platform.u202210587.Hign.Personnel.Interfaces.REST.Resources;

namespace org.higx.platform.u202210587.Hign.Personnel.Interfaces.REST.Transform;

public static class CreateExaminerCommandFromResourceAssembler
{
    public static CreateExaminerCommand ToCommandFromResource(CreateExaminerResource resource)
    {
        return new CreateExaminerCommand(resource.firstName, resource.lastName);
    }
    
}