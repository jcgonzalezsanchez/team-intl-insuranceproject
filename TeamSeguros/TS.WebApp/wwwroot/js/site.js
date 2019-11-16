﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


// Or with jQuery

$(document).ready(function () {
    $('.datepicker').datepicker({
        format: "dd/mm/yyyy",
        changeMonth: true,
        changeYear: true,
        yearRange: '1940:2000'
    });
    $('select').formSelect();
});
