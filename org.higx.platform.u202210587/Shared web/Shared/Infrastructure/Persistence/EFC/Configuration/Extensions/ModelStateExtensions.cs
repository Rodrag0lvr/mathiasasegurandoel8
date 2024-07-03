using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace org.higx.platform.u202210587.Shared_web.Shared.Infrastructure.Persistence.EFC.Configuration.Extensions;

public  static class ModelStateExtensions
{
    public static List<string> GetErrorMessages(this ModelStateDictionary dictionary)
    {
        return dictionary
            .SelectMany(m => m.Value!.Errors)
            .Select(m => m.ErrorMessage)
            .ToList();
    }
}