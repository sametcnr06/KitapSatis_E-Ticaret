using Business.Abstract;
using Business.Concrete;
using DATA.Abstract;
using DATA.Concrete;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyInjection
{
    public static class ServiceDI
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //Repository katmanını ekler.
            services.AddScoped<IRepository<Kitap>, KitapRepository>();
            services.AddScoped<IKullaniciRepository, KullaniciRepository>();
            //Service katmanını ekler.
            services.AddScoped<IKitapService, KitapService>();
            services.AddScoped<IKullaniciService, KullaniciManager>();

            return services;
        }
    }
}
