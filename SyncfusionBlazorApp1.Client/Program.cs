using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;
using Microsoft.Extensions.Http;
using SyncfusionBlazorApp1.Client;

//Register Syncfusion license https://help.syncfusion.com/common/essential-studio/licensing/how-to-generate
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXtdcHRTQmVfVEV2V0Q=");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<IDataProvider, WasmDataProvider>();
builder.Services.AddHttpClient("Data", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
await builder.Build().RunAsync();
