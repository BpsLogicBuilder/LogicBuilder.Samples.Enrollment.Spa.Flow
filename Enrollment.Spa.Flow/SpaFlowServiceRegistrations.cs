using AutoMapper;
using Enrollment.Spa.Flow;
using Enrollment.Spa.Flow.Cache;
using Enrollment.Spa.Flow.Cache.Interfaces;
using Enrollment.Spa.Flow.Interfaces;
using LogicBuilder.App.Spa.AutoMapperProfiles;
using LogicBuilder.App.Utils.Rules;
using LogicBuilder.EntityFrameworkCore.Mapping;
using LogicBuilder.RulesDirector;
using Microsoft.Extensions.Logging.Abstractions;

#pragma warning disable IDE0130 //Microsoft recommended namespace for service registrations
namespace Microsoft.Extensions.DependencyInjection
#pragma warning restore IDE0130
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public static class SpaFlowServiceRegistrations
    {
        public static IServiceCollection AddSpaFlowServices(this IServiceCollection services)
        {
            return services
                .AddAppUtilsServices()
                .AddHttpClient()
                .AddFlowFactories()
                .AddRulesCacheService
                (
                    new RulesLoaderRequest
                    (
                        "Enrollment.Spa.Flow.Rulesets",
                        typeof(FlowActivity),
                        [
                            typeof(LogicBuilder.App.Utils.Interfaces.ITypeHelper).Assembly,
                            typeof(LogicBuilder.App.Spa.Forms.Parameters.CommandButtonParameters).Assembly,
                            typeof(LogicBuilder.App.Spa.Forms.Configuration.CommandButtonDescriptor).Assembly,
                            typeof(LogicBuilder.Forms.Parameters.Expansions.SelectExpandDefinitionParameters).Assembly,
                            typeof(Enrollment.Domain.Entities.UserModel).Assembly,
                            typeof(Enrollment.Data.Entities.User).Assembly,
                            typeof(DirectorBase).Assembly,
                            typeof(string).Assembly
                        ]
                    )
                )
                .AddTransient<ICustomActions, CustomActions>()
                .AddTransient<ICustomDialogs, CustomDialogs>()
                .AddTransient<IFlowManager, FlowManager>()
                .AddTransient<ITransientFlowHelper, TransientFlowHelper>()
                .AddScoped<IFlowDataCache, FlowDataCache>()
                .AddScoped<Progress>();
        }

        public static IServiceCollection AddAutoMapperServices(this IServiceCollection services)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<BaseClassMappings>();
                cfg.AddProfile<ConnectorProfile>();
                cfg.AddProfile<ParameterToDescriptorProfile>();
                cfg.AddProfile<ExpressionParameterToDescriptorMappingProfile>();
                cfg.AddProfile<ExpansionParameterToDescriptorMappingProfile>();
                cfg.AddProfile<ExpressionOperatorsMappingProfile>();
                cfg.AddProfile<ExpansionDescriptorToOperatorMappingProfile>();

            }, new NullLoggerFactory());

            configuration.AssertConfigurationIsValid();

            return services
                .AddSingleton<AutoMapper.IConfigurationProvider>(configuration)
                .AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<AutoMapper.IConfigurationProvider>(), sp.GetService));
        }
    }
}
