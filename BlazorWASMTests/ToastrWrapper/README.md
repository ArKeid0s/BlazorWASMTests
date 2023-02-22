# Toastr Wrapper

## How to use Toastr Wrapper
In order to use Toastr Wrapper, you need to include the following files in your `wwwroot/index.html` page:

	<link href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css" rel="stylesheet" />
	<script src="_content/ToastrWrapper/toastrFunctions.js"></script>
    <script
            src="https://code.jquery.com/jquery-3.6.3.min.js"
            integrity="sha256-pvPw+upLPUjgMXY0G+8O0xUf+/Im1MZjXxxgOcBQBXU="
            crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js"></script>

Then in your `Program.cs` you need to add the following line:

	builder.Services.AddBlazorToastr();

And last in your `App.razor` you need to add the following line in the Router tag after the AppAssembly :

	AdditionalAssemblies="new [] { typeof(ToastrWrapper.ToastrWrapperExamplePage).Assembly }"
