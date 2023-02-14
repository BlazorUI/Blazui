using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Element.Admin.Abstract;

namespace Element.Admin.Sample.ClientRender.PWA
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //builder.Services.AddScoped<IUserService, UserService>();UserService�Լ�ʵ�֣���ûʱ��ʵ���ˣ������ţ�https://docs.microsoft.com/zh-cn/aspnet/core/security/blazor/webassembly/hosted-with-identity-server?view=aspnetcore-3.1
            builder.Services.AddApiAuthorization();

            await builder.Build().RunAsync();
        }
    }
}
