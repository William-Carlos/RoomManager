using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RoomManager.DataAccess.Context;
using RoomManager.DataAccess.Repositories;
using RoomManager.Domain.Interfaces;
using RoomManager.Domain.Services.CoffeeSpaces;
using RoomManager.Domain.Services.People;
using RoomManager.Domain.Services.Rooms;

namespace RoomManager.Web
{
    public static class Recorder
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));

            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<ICoffeeSpaceService, CoffeeSpaceService>();

            services.AddScoped<DbContext, ManagerRoomContext>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<ICoffeeSpaceRepository, CoffeeSpaceRepository>();

            return services;
        }
    }
}
