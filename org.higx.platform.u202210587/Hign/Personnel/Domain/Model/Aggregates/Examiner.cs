using System.ComponentModel.DataAnnotations;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Commands;
using org.higx.platform.u202210587.Hign.Personnel.Domain.Model.ValueObjects;

namespace org.higx.platform.u202210587.Hign.Personnel.Domain.Model.Aggregates;

public class Examiner
{
    public long id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }

    public NationalProviderIdentifier nationalProviderIdentifier { get; set; }

    // Constructor sin parámetros requerido por Entity Framework
    public Examiner()
    {
    }

    // Constructor que toma un CreateExaminerCommand para usar en la lógica de negocio
    public Examiner(CreateExaminerCommand command)
    {
        this.firstName = command.firstName;
        this.lastName = command.lastName;
        this.nationalProviderIdentifier = new NationalProviderIdentifier();
    }
    
}