﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PolyhydraSoftware.Core.UDP.Test;

public static class TestFixtures
{
    public static IHost GetHost(Action<HostBuilderContext, IServiceCollection> registrations)
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((ctx, services) =>
            { 
                registrations.Invoke(ctx, services);
                services.AddLogging(x =>
                {
                    x.AddConsole();
                });
            }).Build();
    }
}