using LegacyApp.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyApp.Middleware
{
    public static class InjectBussines
    {
        public static IServiceCollection AddRegistration(this IServiceCollection prmService)
        {
            prmService.AddSingleton<IUserService, UserService>();
            return prmService;
        }
    }
}
