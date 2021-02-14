using System.IO;
using EffectoryAssignment.Application.Interfaces;
using EffectoryAssignment.Application.Services;
using EffectoryAssignment.Domain.Models;
using EffectoryAssignment.Domain.Repositories;
using EffectoryAssignment.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace EffectoryAssignment.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var json = File.ReadAllText("../EffectoryAssignment.Infrastructure/questionnaire.json");
            var questionnaire = JsonConvert.DeserializeObject<Questionnaire>(json);
            
            services.AddSingleton(questionnaire);
            services.AddScoped<IQuestionnaireRepository, QuestionnaireRepository>();
            
            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Usually this is where i would register the services.
            services.AddScoped<IQuestionsService, QuestionsService>();
            
            return services;
        }
    }
}