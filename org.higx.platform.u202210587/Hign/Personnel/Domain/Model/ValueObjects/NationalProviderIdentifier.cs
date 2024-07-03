namespace org.higx.platform.u202210587.Hign.Personnel.Domain.Model.ValueObjects;
/*
 *
 *public record MaterialSerialNumber(Guid SerialNumber)
{
    public MaterialSerialNumber() : this(Guid.NewGuid())
    {
    }

    public override string ToString()
    {
        return SerialNumber.ToString();
    }
}
 * 
 */
public record NationalProviderIdentifier (Guid nationalProviderIdentifier)
{
    public NationalProviderIdentifier() : this(Guid.NewGuid())
    {
    }

    public override string ToString()
    {
        return nationalProviderIdentifier.ToString();
    }
}