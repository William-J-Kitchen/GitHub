function countdown() {
    var seconds = document.getElementById("seconds").value;

    function tick() {
        seconds--
        timer.innerHTML = seconds;
        var time = setTimeout(tick, 1000); //pauses for 1s, then ticks again
        if (seconds == -1) {
            alert("Time's up!");
            clearTimeout(time);
            timer.innerHTML = "";
        }
    }
    tick();
}

var slideIndex = 1; //starts at the first slide, but hidden due to CSS
showSlides(slideIndex);

// Next/previous controls
function plusSlides(n) {
    showSlides(slideIndex += n);
}

// Thumbnail image controls
function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    if (n > slides.length) {slideIndex = 1} //resets to 1 if you try to increment past the last slide
    if (n < 1) {slideIndex = slides.length} 
    for (i = 0; i < slides.length; i++) { //arrow controls for slides
        slides[i].style.display = "none";
    }
    for (i=0; i < dots.length; i++) { //dot controls for slides
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display = "block"; 
    dots[slideIndex-1].className += " active";
}