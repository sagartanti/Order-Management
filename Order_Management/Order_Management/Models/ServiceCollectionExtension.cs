using Domain;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using System.Data;
using Repository.User;
using FluentValidation;

namespace Order_Management
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, string? connectionstring)
        {
            try
            {
                services.AddSingleton<IDbConnection>(sp => new SqlConnection(connectionstring));
                //services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginValidator>());
                //services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

                services.AddScoped<IValidator<Login>, LoginValidator>();
                services.AddScoped<IValidator<SignUp>, SignUpValidator>();
            }
            catch (Exception ex)
            {
                _ = ex.ToString();
            }
            return services;
        }
    }
}