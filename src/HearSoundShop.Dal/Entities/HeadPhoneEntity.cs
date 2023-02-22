namespace HearSoundShop.Dal.Entities
{
    public class HeadPhoneEntity : BaseEntity
    {
        public string TypeOfConstruction { get; set; } = null!;
        public string TypeOfConnection { get; set; } = null!;
        public bool NoiseSuppression { get; set; }
    }
}
