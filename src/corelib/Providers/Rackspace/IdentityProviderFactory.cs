﻿using System;
using net.openstack.Core;
using net.openstack.Providers.Rackspace.Exceptions;

namespace net.openstack.Providers.Rackspace
{
    internal class IdentityProviderFactory : IProviderFactory<IIdentityProvider>
    {
        public IIdentityProvider Get(string geo)
        {
            switch (geo.ToLower())
            {
                case "dfw":
                case "ord":
                case "us":
                    return new GeographicalIdentityProvider(new Uri(Settings.USIdentityUrlBase));
                case "lon":
                    return new GeographicalIdentityProvider(new Uri(Settings.LONIdentityUrlBase));
                default:
                    throw new UnknownGeographyException(geo);
            }
        }
    }
}