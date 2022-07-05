var global=3

function process() { //adds the global and local variables together
    var local = 6
    console.log(local + global);
}

function process_fail() { //fails to add the variables, because local was declared in another function, and is local to it.
    console.log(local+global);
}

function current_time() { //If time <12, states so. If time >=12, states so.
    if (new Date().getHours() < 12) {
        document.getElementById("Clock").innerHTML = "Time < 12";
    }
    else {
        document.getElementById("Clock").innerHTML = "Time >= 12";
    }
}

//document.write(new Date().getHours());
//document.write(time); //figuring out how these methods work

function Test_Function() { //retrieves the score from index.html. If >=80, declares a pass, else declares a fail.
    Score = document.getElementById("Score").value;
    if (Score>=80) {
        PassFail = "You've passed the test!";
    }
    else {
        PassFail = "You failed the test...";
    }
    document.getElementById("Grade").innerHTML = PassFail;
}

function Time_function() { //Gets system time. If 0<time<12, states morning. If 18>time>=12, states afternoon. Else, states evening.
    var Time = new Date().getHours();
    var Reply;
    if (Time < 12 == Time > 0) {
        Reply = "It is morning time!";
    }
    else if (Time >= 12 == Time < 18) {
        Reply = "It is afternoon.";
    }
    else {
        Reply = "It is evening time.";
    }
    document.getElementById("Time_of_day").innerHTML = Reply;
}