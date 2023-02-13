window.toastrFunctions = {
    showToastrInfo: function (title, message, options, DotNetRef) {
        toastr.options = options;
        toastr.options.onclick = function () {
          DotNetRef.invokeMethodAsync('InfoOnClickCallback');
        };
        toastr.info(message, title);
    },

    showToastrSuccess: function (title, message, options, DotNetRef) {
        toastr.options = options;
        toastr.options.onclick = function () {
            DotNetRef.invokeMethodAsync('SuccessOnClickCallback');
        };
        toastr.success(message, title);
    }
}