var game = { "Title" : "Stardew Valley" , "Developer" : "Concerned Ape" , "Release Year" : "2016" };

var myString = JSON.stringify(game);
document.getElementById("stringify").innerHTML = myString;

var myParse = JSON.parse(myString);
document.getElementById("parse").innerHTML = myParse.Title;

localStorage.setItem("Local" , "Bubba");
document.getElementById("localStorage").innerHTML = localStorage.getItem("Local");

function dblClick() {
    document.getElementById("dblclick").innerHTML="Good job!";
}