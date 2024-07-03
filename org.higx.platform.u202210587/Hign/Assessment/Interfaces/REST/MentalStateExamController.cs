using System.ComponentModel.Design;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using org.higx.platform.u202210587.Hign.Assessment.Domain.Services;
using org.higx.platform.u202210587.Hign.Assessment.Interfaces.REST.Resources;
using org.higx.platform.u202210587.Hign.Assessment.Interfaces.REST.Transform;

namespace org.higx.platform.u202210587.Hign.Assessment.Interfaces.REST;
[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class MentalStateExamController(IMentalStateExamCommandService mentalCommandService): ControllerBase
{
 [HttpPost]
 public async Task<ActionResult<MentalStateExamResource>> CreateMental([FromBody] CreateMentalStateExamResource resource)
 {
  var mental = CreateMentalStateExamCommandFromResourceAssembler.ToCommandFromResource(resource);

  var mentalcommands = await mentalCommandService.Handle(mental);

  var mentalresource = MentalStateExamResourceFromEntityAssembler.ToResourceFromEntity(mentalcommands);

  return CreatedAtAction(nameof(CreateMental), new { id = mentalresource.id }, mentalresource);
 }
}
