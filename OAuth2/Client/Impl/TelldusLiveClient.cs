using Newtonsoft.Json.Linq;
using OAuth2.Configuration;
using OAuth2.Infrastructure;
using OAuth2.Models;
using System;

namespace OAuth2.Client.Impl
{
    /// <summary>
    /// Telldus Live authentication client.
    /// </summary>
    public class TelldusLiveClient : OAuthClient
    {
        public TelldusLiveClient(IRequestFactory factory, IClientConfiguration configuration)
            : base(factory, configuration)
        {
        }

        /// <summary>
        /// Defines URI of service which is called for obtaining request token.
        /// </summary>
        protected override Endpoint RequestTokenServiceEndpoint
        {
            get
            {
                return new Endpoint
                {
                    BaseUri = "http://api.telldus.com",
                    Resource = "/oauth/requestToken"
                };
            }
        }

        /// <summary>
        /// Defines URI of service which should be called to initiate authentication process.
        /// </summary>
        protected override Endpoint LoginServiceEndpoint
        {
            get
            {
                return new Endpoint
                {
                    BaseUri = "http://api.telldus.com",
                    Resource = "/oauth/authorize"
                };
            }
        }

        /// <summary>
        /// Defines URI of service which issues access token.
        /// </summary>
        protected override Endpoint AccessTokenServiceEndpoint
        {
            get
            {
                return new Endpoint
                {
                    BaseUri = "http://api.telldus.com",
                    Resource = "/oauth/accessToken"
                };
            }
        }

        /// <summary>
        /// Defines URI of service which is called to obtain user information.
        /// </summary>
        protected override Endpoint UserInfoServiceEndpoint
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Friendly name of provider (OAuth service).
        /// </summary>
        public override string Name
        {
            get { return "TelldusLive"; }
        }

        /// <summary>
        /// Should return parsed <see cref="UserInfo" /> using content of callback issued by service.
        /// </summary>
        protected override UserInfo ParseUserInfo(string content)
        {
            throw new NotImplementedException();
        }
    }
}