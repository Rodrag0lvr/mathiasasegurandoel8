using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Commands;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Services;
using org.higx.platform.u202210587.Hign.Personnel.Interfaces.REST.Resources;
using org.higx.platform.u202210587.Hign.Personnel.Interfaces.REST.Transform;

namespace org.higx.platform.u202210587.Hign.Personnel;

[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class ExaminerController(IExaminerCommandService examinerCommandService): ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<ExaminerResource>> CreateExaminer([FromBody] CreateExaminerResource resource)
    {
        var createExaminerCommand = CreateExaminerCommandFromResourceAssembler.ToCommandFromResource(resource);

        var examiner = await examinerCommandService.Handle(createExaminerCommand);

        var examinerResource = ExaminerResourceFromEntityAssembler.ToResourceFromEntity(examiner);

        return CreatedAtAction(nameof(CreateExaminer), new { id = examinerResource.id }, examinerResource);
    }
    
}