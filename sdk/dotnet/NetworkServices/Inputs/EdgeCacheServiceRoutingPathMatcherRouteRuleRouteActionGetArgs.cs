// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.NetworkServices.Inputs
{

    public sealed class EdgeCacheServiceRoutingPathMatcherRouteRuleRouteActionGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The policy to use for defining caching and signed request behaviour for requests that match this route.
        /// Structure is documented below.
        /// </summary>
        [Input("cdnPolicy")]
        public Input<Inputs.EdgeCacheServiceRoutingPathMatcherRouteRuleRouteActionCdnPolicyGetArgs>? CdnPolicy { get; set; }

        /// <summary>
        /// CORSPolicy defines Cross-Origin-Resource-Sharing configuration, including which CORS response headers will be set.
        /// Structure is documented below.
        /// </summary>
        [Input("corsPolicy")]
        public Input<Inputs.EdgeCacheServiceRoutingPathMatcherRouteRuleRouteActionCorsPolicyGetArgs>? CorsPolicy { get; set; }

        /// <summary>
        /// The URL rewrite configuration for requests that match this route.
        /// Structure is documented below.
        /// </summary>
        [Input("urlRewrite")]
        public Input<Inputs.EdgeCacheServiceRoutingPathMatcherRouteRuleRouteActionUrlRewriteGetArgs>? UrlRewrite { get; set; }

        public EdgeCacheServiceRoutingPathMatcherRouteRuleRouteActionGetArgs()
        {
        }
    }
}
