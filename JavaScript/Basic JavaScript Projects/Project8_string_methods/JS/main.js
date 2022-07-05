function full_Sentence() { //concatenates the strings in section_1,4
    var section_1 = "This function ";
    var section_2 = "serves the purpose ";
    var section_3 = "of concatenating ";
    var section_4 = "a series of a strings."
    var complete = section_1.concat(section_2, section_3, section_4);
    document.getElementById("Concatenate").innerHTML = complete;
}

function slice_Method() { //Slices out characters after the 29th and presents
    var Sentence = "This method will cut out the final section.";
    var Section = Sentence.slice(29);
    document.getElementById("Slice").innerHTML = Section;
}

function string_Method() { //converts X to a string
    var X = 12;
    document.getElementById("Numbers_to_string").innerHTML = X.toString();
}

function precision_Method() { //cuts pi off at the 6th digit
    var X = 3.141592653589793;
    document.getElementById("Precision").innerHTML = X.toPrecision(6);
}

function fixed_Method() { //sets X to be 8 digits in length.
    var X = 546.32
    document.getElementById("Fixed").innerHTML = X.toFixed(8);
}