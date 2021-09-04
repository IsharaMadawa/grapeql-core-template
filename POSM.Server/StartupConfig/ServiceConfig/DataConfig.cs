﻿using Microsoft.EntityFrameworkCore;
using POSM.Core.Data.Db.Models;

namespace POSM.APIs.GraphQLServer.StartupConfig.ServiceConfig
{
	public static class DataConfig
	{
        public static void ConfigServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<POSMDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
