var temp;
var x = 0;
var maxHeight;
function openChild() {
  temp = open("child.html", "", "width=500,height=500");
  temp.focus();
  setTimeout(function () {
    maxHeight = temp.document.body.scrollHeight;
    var stopInterval = setInterval(function () {
      x += 500;
      if (x <= maxHeight) {
        temp.scrollTo(0, x);
      } else {
        setTimeout(function () {
          clearInterval(stopInterval);
          temp.close();
        }, 2500);
      }
    }, 300);
  }, 300);
}
