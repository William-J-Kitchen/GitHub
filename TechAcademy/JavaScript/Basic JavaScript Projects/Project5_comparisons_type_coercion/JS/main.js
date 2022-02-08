document.write(typeof "Text"); //Displays the type of "Text"
document.write(" " + "12" + 0); //Coerces Java to add 0 to the string 12.

function my_Function1() { //Divides 0 by 0 to return NaN (Not a number)
    document.getElementById("Test1").innerHTML = 0/0;
}
function my_Function2() { //Tests a string to see if it is NaN
    document.getElementById("Test2").innerHTML = isNaN('This is a string');
}
function my_Function3() { //Tests a number to see if it is NaN
    document.getElementById("Test3").innerHTML = isNaN('007');
}

document.write("  " + 2E310); //displays infinity
document.write("  " + -3E310); //displays negative infinity

document.write(10>2); //Boolean true
document.write(10<2); //Boolean false

console.log(2+2); //Console log output of 4
console.log(4==8); //tests if 4 equals 8
console.log(4==4); //tests if 4 equals 4

console.log(10===10);  //tests if 10 equals 10 and is the same data type
console.log(10==="Kevin"); //tests if 10 equals Kevin and is the same data type
console.log(10==="10"); //tests if 10 equals "10" and is the same data type
console.log(10===8); //tests if 10 equals 8 and is the same data type

console.log(10>8 && 2*6==12);  //tests if 10 is greater than 8 and 2*6=12
console.log(10>6 && 10<6); //tests if 10>6 and 10<6
console.log(10>6 || 10<6); //tests if 10>6 or 10<6
console.log(10<6 || 6<3); //tests if 10<6 or 6<3

console.log(!(6>12)); //tests if 6 is not > 12
console.log(!(10>8)); //tests if 10 is not > 8
