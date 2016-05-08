$(function () {
    $('#indexButton').click(function () {

        var persent = $('#indexation').val();

        var prices = $('.price');
        for (var i = 0; i < prices.length; i++) {
            $(prices[i]).text(function (index) {
                return parseFloat($(prices[i]).text()) * (persent / 100 + 1);
            });
        }
    });
});