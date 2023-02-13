using Microsoft.Extensions.DependencyInjection;

namespace BlazorWASMTests.Toastr.Services;

public static class ServiceCollectionExtension
{
	public static IServiceCollection AddBlazorToastr(this IServiceCollection services)
		=> services.AddScoped<ToastrService>();
}