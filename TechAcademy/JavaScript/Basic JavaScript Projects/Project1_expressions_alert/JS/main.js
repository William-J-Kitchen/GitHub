var stringValue = "\"This string\'s full of apostrophes and quotes,\" said Jill\'s sister. " + "Here's some extra text," + " and some more.", secondString=" Second set of text here!", intValue1=3, intValue2=5;  //Defines 4 variables, two of which are strings.
document.write(stringValue+secondString+" "+intValue1); //concatenates three of the previously defined variables
var Sum=intValue1+intValue2;
document.write(", " + Sum + "."); //writes the value of Sum, with some formatting.
window.alert('Hello, world!'); //pops up the text
document.write(' Hello, woorrrrld!'); //outputs the text into the body

function Button() { //Defining a function called Button
    var buttonStr = "This is the button text!"; //Defining a string called buttonStr
    document.getElementById("Button_Text").innerHTML = buttonStr; //Putting the value of the variable in the HTML elementFromPoint with the "Button_Text" ID
}