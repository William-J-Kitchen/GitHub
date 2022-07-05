function Button() { //Defining a function called Button
    var buttonStr = "You clicked the button!"; //Defining a string called buttonStr
    document.getElementById("Button_Text").innerHTML = buttonStr; //Putting the value of the variable in the HTML elementFromPoint with the "Button_Text" ID
}

function myFunction() {
    var sentence = "I am learning";//defining the variable sentence
    sentence += " a lot from this course!";//concatenating text onto the sentence variable
    document.getElementById("Concatenate").innerHTML = sentence;//changes the Concatenate element to the sentence variable, when function is called.
}

