using System.ComponentModel;

namespace BlazorWASMTests.ToastrWrapper.Enumerations;

public enum ToastrShowOptions
{
	[Description("fadeIn")] FadeIn,
	[Description("slideDown")] SlideDown
}