﻿document.write("<script type='text/javascript'  src='../Scripts/main/jquery.cookie.js'></script>");
window.console = window.console || (function () {
    var c = {}; c.log = c.warn = c.debug = c.info = c.error = c.time = c.dir = c.profile = c.clear = c.exception = c.trace = c.assert = function () {
    };
    return c;
})(); jQuery(document).ready(function ($) {
    if ($.cookie('layout_color') != null) {
        $("#colors-style").attr("href", $.cookie('layout_color'));
    }
    $(".color_1").click(function () {
        $("#colors-style").attr("href", "css/colors/color_1.css"); $.cookie('layout_color', 'css/colors/color_1.css'); return false;
    });
    $(".color_2").click(function () {
        $("#colors-style").attr("href", "css/colors/color_2.css"); $.cookie('layout_color', 'css/colors/color_2.css'); return false;
    });
    $(".color_3").click(function () {
        $("#colors-style").attr("href", "css/colors/color_3.css"); $.cookie('layout_color', 'css/colors/color_3.css'); return false;
    }); $(".color_4").click(function () {
        $("#colors-style").attr("href", "css/colors/color_4.css"); $.cookie('layout_color', 'css/colors/color_4.css'); return false;
    }); $(".color_5").click(function () {
        $("#colors-style").attr("href", "css/colors/color_5.css"); $.cookie('layout_color', 'css/colors/color_5.css'); return false;
    }); $(".color_6").click(function () {
        $("#colors-style").attr("href", "css/colors/color_6.css"); $.cookie('layout_color', 'css/colors/color_6.css'); return false;
    }); $(".color_7").click(function () {
        $("#colors-style").attr("href", "css/colors/color_7.css"); $.cookie('layout_color', 'css/colors/color_7.css'); return false;
    }); $(".color_8").click(function () {
        $("#colors-style").attr("href", "css/colors/color_8.css"); $.cookie('layout_color', 'css/colors/color_8.css'); return false;
    }); $(".color_9").click(function () {
        $("#colors-style").attr("href", "css/colors/color_9.css"); $.cookie('layout_color', 'css/colors/color_9.css'); return false;
    }); $(".color_10").click(function () {
        $("#colors-style").attr("href", "css/colors/color_10.css"); $.cookie('layout_color', 'css/colors/color_10.css'); return false;
    }); $(".color_11").click(function () {
        $("#colors-style").attr("href", "css/colors/color_11.css"); $.cookie('layout_color', 'css/colors/color_11.css'); return false;
    }); $(".color_12").click(function () {
        $("#colors-style").attr("href", "css/colors/color_12.css"); $.cookie('layout_color', 'css/colors/color_12.css'); return false;
    }); $(".color_13").click(function () {
        $("#colors-style").attr("href", "css/colors/color_13.css"); $.cookie('layout_color', 'css/colors/color_13.css'); return false;
    }); $(".color_14").click(function () {
        $("#colors-style").attr("href", "css/colors/color_14.css"); $.cookie('layout_color', 'css/colors/color_14.css'); return false;
    }); $(".color_15").click(function () {
        $("#colors-style").attr("href", "css/colors/color_15.css"); $.cookie('layout_color', 'css/colors/color_15.css'); return false;
    }); $(".color_16").click(function () {
        $("#colors-style").attr("href", "css/colors/color_16.css"); $.cookie('layout_color', 'css/colors/color_16.css'); return false;
    }); $(".color_17").click(function () {
        $("#colors-style").attr("href", "css/colors/color_17.css"); $.cookie('layout_color', 'css/colors/color_17.css'); return false;
    }); $(".color_18").click(function () {
        $("#colors-style").attr("href", "css/colors/color_18.css"); $.cookie('layout_color', 'css/colors/color_18.css'); return false;
    }); $(".color_19").click(function () {
        $("#colors-style").attr("href", "css/colors/color_19.css"); $.cookie('layout_color', 'css/colors/color_19.css'); return false;
    }); $(".color_20").click(function () {
        $("#colors-style").attr("href", "css/colors/color_20.css"); $.cookie('layout_color', 'css/colors/color_20.css'); return false;
    }); $(".color_21").click(function () {
        $("#colors-style").attr("href", "css/colors/color_21.css"); $.cookie('layout_color', 'css/colors/color_21.css'); return false;
    }); $(".color_22").click(function () {
        $("#colors-style").attr("href", "css/colors/color_22.css"); $.cookie('layout_color', 'css/colors/color_22.css'); return false;
    }); $(".color_23").click(function () {
        $("#colors-style").attr("href", "css/colors/color_23.css"); $.cookie('layout_color', 'css/colors/color_23.css'); return false;
    }); $(".color_24").click(function () {
        $("#colors-style").attr("href", "css/colors/color_24.css"); $.cookie('layout_color', 'css/colors/color_24.css'); return false;
    }); $(".color_25").click(function () {
        $("#colors-style").attr("href", "css/colors/color_25.css"); $.cookie('layout_color', 'css/colors/color_25.css'); return false;
    }); $(".color_26").click(function () {
        $("#colors-style").attr("href", "css/colors/color_26.css"); $.cookie('layout_color', 'css/colors/color_26.css'); return false;
    }); $(".color_27").click(function () {
        $("#colors-style").attr("href", "css/colors/color_27.css"); $.cookie('layout_color', 'css/colors/color_27.css'); return false;
    }); $(".color_28").click(function () {
        $("#colors-style").attr("href", "css/colors/color_28.css"); $.cookie('layout_color', 'css/colors/color_28.css'); return false;
    }); $(".color_29").click(function () {
        $("#colors-style").attr("href", "css/colors/color_29.css"); $.cookie('layout_color', 'css/colors/color_29.css'); return false;
    }); $(".color_30").click(function () {
        $("#colors-style").attr("href", "css/colors/color_30.css"); $.cookie('layout_color', 'css/colors/color_30.css'); return false;
    }); $('#custumize-style').animate({ left: '-270px' });
    $('#custumize-style a.switcher').click(function (e) {
        e.preventDefault();
        var div = $('#custumize-style');
        console.log(div.css('left'));
        if (div.css('left') === '-270px') {
            $('#custumize-style').animate({ left: '0px' });
            $(this).addClass('open');
            $(this).removeClass('closed');
        } else {
            $('#custumize-style').animate({ left: '-270px' });
            $(this).addClass('closed');
            $(this).removeClass('open');
        }
    })
    $('#button-reset a').click(function (e) {
        $("#colors-style").attr("href", "css/colors/color_4.css");
        $.cookie('layout_color', 'css/colors/color_4.css');
        return false;
    })
});