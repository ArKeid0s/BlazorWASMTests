using System.Text.Json.Serialization;
using BlazorWASMTests.Toastr.CustomConverters;
using BlazorWASMTests.Toastr.Enumerations;

namespace BlazorWASMTests.Toastr;

public class ToastrOptions
{
	[JsonConverter(typeof(CustomEnumDescriptionConverter<ToastrPositionOptions>))]
	[JsonPropertyName("positionClass")]
	public ToastrPositionOptions Position { get; set; }

	[JsonConverter(typeof(CustomEnumDescriptionConverter<ToastrHideOptions>))]
	[JsonPropertyName("hideMethod")]
	public ToastrHideOptions HideMethod { get; set; }

	[JsonConverter(typeof(CustomEnumDescriptionConverter<ToastrShowOptions>))]
	[JsonPropertyName("showMethod")]
	public ToastrShowOptions ShowMethod { get; set; }

	[JsonPropertyName("closeButton")]
	public bool CloseButton { get; set; }
	
	[JsonPropertyName("hideDuration")]
	public int HideDuration { get; set; }
}