using System.ComponentModel;

namespace BlazorWASMTests.ToastrWrapper.Enumerations;

public enum ToastrHideOptions
{
	[Description("fadeOut")] FadeOut,
	[Description("slideUp")] SlideUp
}