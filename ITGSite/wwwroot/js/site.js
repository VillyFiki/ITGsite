$(document).ready(function () {
    $(".example").hide();
    $(".dropdown").hide();
    $("#menu div").click(function (e) {
        $(this).next().slideToggle();
        var text = $("span", this).text();
        $(this).find('.expand').toggleClass('active');
    });
    $(".examplecontent div").click(function (e) {
        $(this).next().slideToggle();
        var text = $("span", this).text();
        $(this).find('.expand').toggleClass('active');
    });
    $(".dropdown-title").click(function (e) {
        $(".dropdown").slideToggle();
        var text = $("span", this).text();
        $(this).find('.expand').toggleClass('active');
    });

});