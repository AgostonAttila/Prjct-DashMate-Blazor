using Blazored.LocalStorage;
using Dashboard;
using Dashboard.StateContainers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });




//LocalStorage
builder.Services.AddBlazoredLocalStorage();

//Services

//State containers
builder.Services.AddSingleton<AppState>();

//Authorization - Authentication
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHFqVkNrXVNbdV5dVGpAd0N3RGlcdlR1fUUmHVdTRHRcQl5hT39UdEFmWXZdc3c=;Mgo+DSMBPh8sVXJ1S0d+X1RPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSX1RcERkW3tbcH1RQWM=;ORg4AjUWIQA/Gnt2VFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5QdENiXn1adXRcQGFf;MTQ3NjIyM0AzMjMxMmUzMTJlMzMzNVdKYmNkS0E4dFJKY0NONGZKSzcwanRRRHh6TkR4VSt4SW1JVTVYa2dBU2c9;MTQ3NjIyNEAzMjMxMmUzMTJlMzMzNUNtVmU1VFFnbk5EdG5IQVREdFNYZi81Z21CTUZab2JzSklEVHZWUllFa3M9;NRAiBiAaIQQuGjN/V0d+XU9Hc1RDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdUdlWHhcdHFURmJbUg==;MTQ3NjIyNkAzMjMxMmUzMTJlMzMzNUw1Nld1S1lCdXlLTzUwd2M3V2I5Qk9xcm9DOUozTTlhM0NGcTBaSi9yWkU9;MTQ3NjIyN0AzMjMxMmUzMTJlMzMzNVFZWUlrZTcxbDVNSFRoWFAydjVMV082MUpOcmFaYVgyTGRsQ1RPUDdFd1E9;Mgo+DSMBMAY9C3t2VFhhQlJBfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5QdENiXn1adXVVT2hf;MTQ3NjIyOUAzMjMxMmUzMTJlMzMzNVZic0NwNVRQV09hcmVrdWtpNlBmZUdkS3RnTGYzL2FiV3IyZFdUc1J2VFk9;MTQ3NjIzMEAzMjMxMmUzMTJlMzMzNWQ4V091d1MrZ3UydXIwSVJiV0Z2cDQ4TkZDdEFScWRjVkNqVmlrU28rTGM9;MTQ3NjIzMUAzMjMxMmUzMTJlMzMzNUw1Nld1S1lCdXlLTzUwd2M3V2I5Qk9xcm9DOUozTTlhM0NGcTBaSi9yWkU9");

await builder.Build().RunAsync();
