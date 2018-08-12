﻿

namespace InterfaceSegregation.Configuration1
{
    public interface IConfigurationSettings 
    {
        // performance tuning settings
        int CacheDuration { get; }

        // data access settings
        string DatabaseServerName { get; }
        string DatabaseName { get; }
        string DatabaseUserName { get; }
        string DatabasePassword { get; }
        
        // web service api settings
        string WebServiceBaseUri { get; }
    }
}