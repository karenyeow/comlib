﻿using Comlib.Common.Helpers.Connections;
using Microsoft.Extensions.Configuration;

namespace Comlib.Common.Helpers.Middlewares
{
    public class APILoggingConnectionProvider:DBConnectionProvider, IAPILoggingConnectionProvider 
    {
        public APILoggingConnectionProvider (IConfiguration configuration): base ("APILogging",DBEnum.SQL , configuration)
        {

        }
    }
}
