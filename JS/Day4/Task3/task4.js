var imgs = document.getElementsByTagName("img");
var counter = 0;
var stopInterval = null;
function startInterval() {
  stopInterval = setInterval(function () {
    counter++;
    if (counter == imgs.length) {
      imgs[counter - 1].src = "img/marble1.jpg";
      counter = 0;
    }
    imgs[counter].src = "img/marble3.jpg";
    imgs[counter - 1].src = "img/marble1.jpg";
  }, 500);
}
startInterval();
for (var i = 0; i < imgs.length; i++) {
  imgs[i].onmouseover = function () {
    if (stopInterval != null) clearInterval(stopInterval);
  };
}

for (var i = 0; i < imgs.length; i++) {
  imgs[i].onmouseleave = function () {
    startInterval();
  };
}
