using System.ComponentModel;

namespace BlazorWASMTests.Toastr.Enumerations;

public enum ToastrShowOptions
{
	[Description("fadeIn")] FadeIn,
	[Description("slideDown")] SlideDown
}