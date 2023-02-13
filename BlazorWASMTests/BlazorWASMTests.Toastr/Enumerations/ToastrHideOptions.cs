using System.ComponentModel;

namespace BlazorWASMTests.Toastr.Enumerations;

public enum ToastrHideOptions
{
	[Description("fadeOut")] FadeOut,
	[Description("slideUp")] SlideUp
}