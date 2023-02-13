using Microsoft.JSInterop;

namespace BlazorWASMTests.Toastr.Services;

public class ToastrService
{
	private IJSRuntime _jsRuntime;

	public ToastrService(IJSRuntime jSRuntime)
	{
		_jsRuntime = jSRuntime;
	}

	public async Task ShowInfoMessage(string message, ToastrOptions options)
	{
		await _jsRuntime.InvokeVoidAsync("toastrFunctions.showToastrInfo", message, options);
	}
}