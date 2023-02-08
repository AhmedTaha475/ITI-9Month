// var line = document.getElementsByTagName("line")[0];

// var interval = setInterval(function () {
//   if (line.x2.baseVal.value >= 600) {
//     alert("Animation End");
//     clearInterval(interval);
//   } else {
//     line.setAttribute("x2", line.x2.baseVal.value + 50);
//     line.setAttribute("y2", line.y2.baseVal.value + 50);
//   }
// }, 500);

var animation = document.getElementById("end");
animation.addEventListener("endEvent", function () {
  alert("Animation Ended");
});
