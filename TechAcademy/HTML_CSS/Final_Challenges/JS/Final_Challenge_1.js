window.addEventListener('DOMContentLoaded', () => {
    document.body.classList.remove('fade-out');
});

function validateForm() {
    let x = document.forms["myForm"]["fname", "lname", "phone"].value;
    if (x == "") {
      alert("All forms must be filled out.");
      return false;
    }
  }

function openForm() {
    document.getElementById("myForm").style.display = "block";
}


function closeForm() {
    document.getElementById("myForm").style.display = "none";
}

var i=0;
var root = document.querySelector('.fadein');
var els = root.querySelectorAll(':not(:first-child)');
for (i=0; i < els.length; i++) {
  els[i].classList.add('is-hidden');
}
root.addEventListener('transitionend', function(){
  root.insertBefore(root.querySelector(':first-child.is-hidden'), null);
});
setInterval(function(){
  root.querySelector(':first-child').classList.add('is-hidden');
  root.querySelector(':nth-child(2)').classList.remove('is-hidden');
}, 3000)