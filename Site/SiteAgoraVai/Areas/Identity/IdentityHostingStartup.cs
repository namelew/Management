using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SiteAgoraVai.Areas.Identity.Data;
using SiteAgoraVai.Data;

[assembly: HostingStartup(typeof(SiteAgoraVai.Areas.Identity.IdentityHostingStartup))]
namespace SiteAgoraVai.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SiteContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SiteContextConnection")));

                services.AddDefaultIdentity<SiteUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<SiteContext>();
            });
        }
    }
}