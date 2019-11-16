// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.



// Or with jQuery

$(document).ready(function () {
    $('.sidenav').sidenav();
    $('.datepicker').datepicker({
        dateFormat: 'dd/mm/yy',
        yearRange: [1900, 3000],
    });
    $('select').formSelect();
});

