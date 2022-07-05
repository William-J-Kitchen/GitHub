function Call_Loop() { //counts down from 10 to 0
    var Countdown = "";
    var X = 10;
    while (X > -1) {
        Countdown += "<br>" + X;
        X--;
    }
    document.getElementById("Loop").innerHTML = Countdown;

}

var string = "123456789"
let length = string.length;
document.getElementById("String_Length").innerHTML = length;


var Instruments = ["Guitar", "Drums", "Piano", "Bass", "Violin", "Trumpet", "Flute"];
var Content = "";
var Y;

function for_Loop() { //Goes through Instruments and lists them out, in order.
    for (Y = 0; Y < Instruments.length; Y++) {
    Content += Instruments[Y] + "<br>";
    }
    document.getElementById("List_of_Instruments").innerHTML = Content;
}

var Test_Array = ["This", " is", " an", " array."]
var Complete_String = ""
var Count;

function array_Function() { //puts Test_Array into a contiguous string
    
    for (Count = 0; Count < Test_Array.length; Count++) {
        Complete_String += Test_Array[Count];
        }
        document.getElementById("Array").innerHTML = Complete_String;
}

function constant_function() { 
    const Immutable = {location:"Unknown", origin:"Unknown", duration:"Infinite"}
    Immutable.name = "Bo" //adds a name value to the const Immutable
    Immutable.origin = "the beginning" //changes the origin value of Immutable
    document.getElementById("Constant").innerHTML = Immutable.name + " has been here since " + Immutable.origin + ".";
}

var Z = 100;
function letvar_function() { 
    let Z = 50;
    document.getElementById("LetVar").innerHTML = Z;
}


document.getElementById("Return").innerHTML = return_Function("letter");
function return_Function(mail) { //returns mail with a value of "letter"
    return "Sending back the " + mail + ".";  
}

let game = { //This object has the description method, which puts its values into a sentence.
    name: "Baldur's Gate ",
    genre: "RPG ",
    release_date: "1998 ",
    developer: "Bioware",
    description: function() {
        return "The game " + this.name + "is an " + this.genre + "developed by " + this.developer + " in " + this.release_date;
    }
}
document.getElementById("Game_Object").innerHTML = game.description();

for (let i =0; i < 10; i++) { //breaks when i reaches 8, and displays the total of the previous numbers
    if (i === 8) {break;}
    text = i;
    document.getElementById("Break").innerHTML = text;
}


for (let i =0; i < 10; i++) {
    if (i === 8) {continue;} //skips the value of 8, but continues and displays the total of all other values of i.
    text += i;
    document.getElementById("Continue").innerHTML = text;
}

