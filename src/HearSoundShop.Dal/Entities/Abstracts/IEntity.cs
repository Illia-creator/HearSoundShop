namespace HearSoundShop.Dal.Entities.Abstracts
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
