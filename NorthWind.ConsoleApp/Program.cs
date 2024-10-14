using Microsoft.Extensions.Logging;
using NorthWind.Entities;

var Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();

using IHost AppHost = Builder.Build();

IAppLogger logger = AppHost.Services.GetRequiredService<IAppLogger>();
logger.WriteLog("Aplication started");


IProductService service = AppHost.Services.GetRequiredService<IProductService>();
service.Add("Demo", "Azucar refinada");
