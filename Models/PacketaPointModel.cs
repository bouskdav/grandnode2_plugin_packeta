namespace Shipping.Packeta.Models
{
    public class PacketaPointModel
    {
        public string id { get; set; }
        public string note { get; set; }
        public string type { get; set; }
        //public string lockerProvider { get; set; }
        //public string partnerReference { get; set; }
        public OpeningHours openingHours { get; set; }
        public Location location { get; set; }
        public Contactinfo contactInfo { get; set; }
        public Paymentoptions paymentOptions { get; set; }
        public bool enabled { get; set; }
        public bool dropOffAllowed { get; set; }
        public Features features { get; set; }
        //public string[] photos { get; set; }
        public string partner { get; set; }
        public string pickupPointResult { get; set; }
    }

    public class OpeningHours
    {
        public OpeningHoursInterval[] monday { get; set; }
        public OpeningHoursInterval[] tuesday { get; set; }
        public OpeningHoursInterval[] wednesday { get; set; }
        public OpeningHoursInterval[] thursday { get; set; }
        public OpeningHoursInterval[] friday { get; set; }
        public OpeningHoursInterval[] saturday { get; set; }
        public OpeningHoursInterval[] sunday { get; set; }
    }

    public class OpeningHoursInterval
    {
        public string open { get; set; }
        public string close { get; set; }
    }

    public class Location
    {
        public Address address { get; set; }
        public Coordinates coordinates { get; set; }
    }

    public class Address
    {
        public string city { get; set; }
        public string country { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public string floorSpecification { get; set; }
        public string department { get; set; }
        public string note { get; set; }
    }

    public class Coordinates
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

    public class Contactinfo
    {
        public string phone { get; set; }
        public string email { get; set; }
        public string web { get; set; }
        public string name { get; set; }
    }

    public class Paymentoptions
    {
        public bool prepaidAllowed { get; set; }
        public bool cardPaymentAllowed { get; set; }
        public bool codAllowed { get; set; }
        public bool onlineCodAllowed { get; set; }
    }

    public class Features
    {
        public bool openInLateAfternoon { get; set; }
        public bool openOnWeekends { get; set; }
        public bool expressAllowed { get; set; }
        public bool returnAllowed { get; set; }
        public bool pickupAllowed { get; set; }
    }

}
