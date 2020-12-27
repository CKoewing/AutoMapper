namespace AutoMapper.Mappers
{
    public interface IObjectMapperInfo : IObjectMapper
    {
        TypePair GetAssociatedTypes(in TypePair initialTypes);
    }
}