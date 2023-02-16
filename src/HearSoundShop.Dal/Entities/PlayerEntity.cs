namespace HearSoundShop.Dal.Entities
{
    public class PlayerEntity : BaseEntity
    {
        public bool EnebleBluetooth { get; set; }
        public bool EnebleWiFi { get; set; }
        public int Memory { get; set; }
    }
}
