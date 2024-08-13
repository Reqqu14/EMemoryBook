using EMemoryBook.Domain.Repositories;
using EMemoryBook.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace EMemoryBook.Infrastructure
{
    public static class Bootstraper
    {
        public static void AddMediatrDatabaseValidationAndServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EMemoryBookDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("EMemoryBookCs")));

            //services.AddMediatR(typeof(Bootstraper));
            services.AddScoped<IUserRepository, UserRepository>();
            
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<ITemplateRepository, TemplateRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}
