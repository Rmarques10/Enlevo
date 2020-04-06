// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function setActiveMenuLink() {
    var currentLink = window.location.href;
    var menuLinks = $(".linkPage");
    var active = $(".a1");

    for (var i = 0, arrLength = menuLinks.length; i < arrLength; i++) {
        if ($(menuLinks[i]).attr("href") == "/" && window.location.pathname == "/") {
            $(menuLinks[i]).parents(".list_item").addClass("active");

        } else if ($(menuLinks[i]).attr("href") !== "/" && currentLink.indexOf($(menuLinks[i]).attr("href")) !== -1) {
            $(menuLinks[i]).parents(".list_item").addClass("active");
        }
    }
}

$(document).ready(function () {
    setActiveMenuLink();
});

var menu_item = $(".list_item");

$(".list_item").click(function () {
    menu_item.removeClass("active");

    $(this).addClass("active");


});