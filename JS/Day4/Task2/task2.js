var myImg = document.getElementsByTagName("img")[0];
var prvBtn = document.getElementById("prevBtn");
var slideBtn = document.getElementById("startSlide");
var stpBtn = document.getElementById("stopSlide");
var nextBtn = document.getElementById("nextBtn");

var counter = 1;
var stopInterval = null;
nextBtn.onclick = function () {
  counter++;
  if (counter == 7) {
    counter = 6;
  }
  myImg.src = "img/" + counter + ".jpg";
};

prvBtn.onclick = function () {
  counter--;
  if (counter == 0) {
    counter = 1;
  }
  myImg.src = "img/" + counter + ".jpg";
};

slideBtn.onclick = function () {
  stopInterval = setInterval(function () {
    counter++;
    if (counter == 7) counter = 1;
    myImg.src = "img/" + counter + ".jpg";
    console.log(counter);
  }, 2000);
};

stpBtn.onclick = function () {
  if (stopInterval != null) {
    clearInterval(stopInterval);
  }
};
