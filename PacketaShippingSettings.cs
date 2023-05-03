using Grand.Domain.Configuration;

namespace Shipping.Packeta
{
    public class PacketaShippingSettings : ISettings
    {
        public bool LimitMethodsToCreated { get; set; }
        public int DisplayOrder { get; set; }

    }
}
