setCookie("visits", parseInt(getCookie("visits")) + 1);
var myName = document.getElementById("myName");
var myvisits = document.getElementById("myVisits");
myName.style.color = getCookie("userColor");
myvisits.style.color = getCookie("userColor");
if (getCookie("userGender") == "male") {
  document.getElementById("myImg").src = "img/1.jpg";
} else {
  document.getElementById("myImg").src = "img/2.jpg";
}

myName.innerText = getCookie("userName");
myvisits.innerText = getCookie("visits");
