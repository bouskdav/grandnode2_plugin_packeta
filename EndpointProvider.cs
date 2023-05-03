using Grand.Infrastructure.Endpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Shipping.Packeta
{
    public partial class EndpointProvider : IEndpointProvider
    {
        public void RegisterEndpoint(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapControllerRoute("Plugins.Packeta.Points",
                 "Plugins/Packeta/Points",
                 new { controller = "PacketaShipping", action = "Points" }
            );
        }

        public int Priority => 0;
    }
}
