namespace HearSoundShop.Dal.Entities
{
    public class HeadPhoneEntity : BaseEntity
    {
        public string TypeOfConstruction { get; set; }
        public string TypeOfConnection { get; set; }
        public bool NoiseSuppression { get; set; }
    }
}
