using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;

namespace Shipping.Packeta.Models
{
    public class PacketaShippingListModel : BaseModel
    {
        [GrandResourceDisplayName("Plugins.Shipping.Packeta.Fields.LimitMethodsToCreated")]
        public bool LimitMethodsToCreated { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.Packeta.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}