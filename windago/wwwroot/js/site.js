// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function clickMe() {
    var rows = document.getElementsByClassName("row");
    for (let i = 0; i <= rows.length - 1; i++) {
        var row = rows[i];
        row.textContent = "HELLO YOU!";
        row.style.color = "blue";
    }
}