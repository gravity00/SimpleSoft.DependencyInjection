﻿namespace SimpleSoft.Extensions.DependencyInjection.Tests.ServiceMocks.ForConfigurator
{
    using Microsoft.Extensions.DependencyInjection;

    public class MockServiceConfigurator01 : IServiceConfigurator
    {
        public void Configure(IServiceCollection services)
        {
            services.AddSingleton<IMockServiceConfiguratorService, MockServiceConfiguratorService>();
        }
    }
}
