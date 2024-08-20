using EMemoryBook.Application.Interfaces;
using EMemoryBook.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EMemoryBook.Application
{
    public static class Bootstraper
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IEventService, EventService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITemplateService, TemplateService>();
            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<IMessageService, MessageService>();

        }
    }
}

