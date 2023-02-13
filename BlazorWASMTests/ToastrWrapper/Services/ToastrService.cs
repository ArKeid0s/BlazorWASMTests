using Microsoft.JSInterop;

namespace BlazorWASMTests.ToastrWrapper.Services;

public class ToastrService
{	
	private IJSRuntime _jsRuntime;

	public ToastrService(IJSRuntime jSRuntime)
	{
		_jsRuntime = jSRuntime;
	}

	public async Task ShowInfoMessageAsync(string title, string message, ToastrOptions options)
	{
		await _jsRuntime.InvokeVoidAsync("toastrFunctions.showToastrInfo", title, message, options, DotNetObjectReference.Create(this));
	}
	
	public async Task ShowSuccessMessageAsync(string title, string message, ToastrOptions options)
	{
		await _jsRuntime.InvokeVoidAsync("toastrFunctions.showToastrSuccess", title, message, options, DotNetObjectReference.Create(this));
	}
	
	[JSInvokable]
	public void InfoOnClickCallback()
	{
		Console.WriteLine("The onClick event has been triggered on an info message.");
	}
	
	[JSInvokable]
	public void SuccessOnClickCallback()
	{
		Console.WriteLine("The onClick event has been triggered on a success message.");
	}
}