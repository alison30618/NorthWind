﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Microsoft.Extensions.DependencyInjection;

public static class DependecyContainer
{
    public static IServiceCollection AddNorthWindServices(
        this IServiceCollection services)
    {
        //services.addDebugWriter();
        //services.addServices();
        return services;
    }
   
}
