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
            services.AddTransient<IUserRepository, UserRepository>();           
            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<ITemplateRepository, TemplateRepository>();
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IPaymentRepository, PaymentRepository>();
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}
