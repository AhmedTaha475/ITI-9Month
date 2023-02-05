var red = document.getElementById("red");
var green = document.getElementById("green");
var blue = document.getElementById("blue");
var text = document.getElementById("text");
text.style.color = "rgb(0,0,0)";
red.addEventListener("change", function () {
  text.style.color =
    "rgb(" + red.value + "," + green.value + "," + blue.value + ")";
});
green.addEventListener("change", function () {
  text.style.color =
    "rgb(" + red.value + "," + green.value + "," + blue.value + ")";
});
blue.addEventListener("change", function () {
  text.style.color =
    "rgb(" + red.value + "," + green.value + "," + blue.value + ")";
});
