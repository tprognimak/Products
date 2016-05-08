$(function () {
    $.ajaxSetup({ cache: false });
    $(".popupItem").click(function (e) {
        debugger;
        e.preventDefault();
        $.get(this.href, function (data) {
            $('#dialogContent').html(data);
            $('#modDialog').modal('show');
        });
    });
})