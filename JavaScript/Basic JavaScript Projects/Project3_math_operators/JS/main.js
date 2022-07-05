function sumFunction() { //Adds the 2 numbers, returns sum
    var sum = 2 + 2;
    document.getElementById("Math1").innerHTML = sum;
}
function subFunction() { //Subtracts the 2 numbers, returns sub
    var sub = 2 - 2;
    document.getElementById("Math2").innerHTML = sub;
}
function multFunction() { //Multiplies the 2 numbers, returns mult
    var mult = 2 * 2;
    document.getElementById("Math3").innerHTML = mult;
}

function divFunction() { //divides the 2 numbers, returns div
    var div = 2 / 2;
    document.getElementById("Math4").innerHTML = div;
}

function comboFunction() { //Adds, then divides, returns combo
    var combo = (1 + 1) / 2;
    document.getElementById("Math5").innerHTML = combo;
}

function remainderFunction() { //finds the remainder, returns remainder
    var remainder = 65 % 6;
    document.getElementById("Math6").innerHTML = remainder;
}

function negationFunction() { //returns the negation of natural
    var natural = 6;
    document.getElementById("Math7").innerHTML = -natural;
}

function incrementFunction() { //increments and returns increment
    var increment = 9;
    increment++;
    document.getElementById("Math8").innerHTML = increment;
}

function decrementFunction() { //decrements and returns decrement
    var decrement = 9;
    decrement--;
    document.getElementById("Math9").innerHTML = decrement;
}

x=(Math.random() * 100); //generates a random number, 1-100
window.alert(Math.round(x)) //pops up x, rounded
window.alert(Math.abs(-3)); //pops up the absolute value of -3
window.alert(Math.PI); //pops up pi