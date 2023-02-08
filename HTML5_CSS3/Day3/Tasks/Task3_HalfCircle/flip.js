var counter = 1;
var myUse = document.getElementById("use");
var stopInterval = setInterval(function () {
  if (counter == 11) {
    myUse.setAttribute("href", "#rect3");
    clearInterval(stopInterval);
  } else {
    if (counter % 2 == 0) myUse.setAttribute("href", "#rect2");
    else myUse.setAttribute("href", "#rect1");
    counter++;
  }
}, 1000);
