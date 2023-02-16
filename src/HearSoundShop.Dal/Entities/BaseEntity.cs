using HearSoundShop.Dal.Entities.Abstracts;

namespace HearSoundShop.Dal.Entities
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirmName { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public string TypeOfProduct { get; set; }
    }
}
