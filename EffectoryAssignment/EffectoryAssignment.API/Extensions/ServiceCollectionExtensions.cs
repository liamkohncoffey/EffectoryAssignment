using EffectoryAssignment.Application.Interfaces;
using EffectoryAssignment.Application.Services;
using EffectoryAssignment.Domain.Repositories;
using EffectoryAssignment.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EffectoryAssignment.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            //Usually this is where i would register the persistence layer
            services.AddScoped<IQuestionnaireRepository, QuestionnaireRepository>();
            
            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Usually this is where i would register the services.
            services.AddScoped<IQuestionnaireService, QuestionnaireService>();
            
            return services;
        }
    }
}