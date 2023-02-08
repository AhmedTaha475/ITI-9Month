var canvas = document.getElementById("c1");
var ctx = canvas.getContext("2d");

var x = 110;
var flag = true;

var interval = setInterval(function () {
  if (x >= 400) {
    //clearInterval(interval);
    flag = false;
  } else if (x <= 110) {
    flag = true;
  }

  if (flag == true) {
    paint(x);
    x += 30;
  } else if (flag == false) {
    x -= 30;
    paint(x);
  }
}, 200);

function paint(x) {
  var rect1Grad = ctx.createLinearGradient(0, 0, 0, 250);
  rect1Grad.addColorStop(0, "#71CBF4");
  rect1Grad.addColorStop(1, "white");
  var rect2Grad = ctx.createLinearGradient(0, 0, 0, 500);

  rect2Grad.addColorStop(0, "white");
  rect2Grad.addColorStop(0.2, "#A0DD4B");
  rect2Grad.addColorStop(0.5, "#A0DD4B");
  rect2Grad.addColorStop(1, "white");
  //#A0DD4B
  ctx.fillStyle = rect1Grad;
  ctx.fillRect(50, 50, 400, 300);
  ctx.fillStyle = rect2Grad;
  ctx.fillRect(50, 260, 400, 200);

  ctx.moveTo(180, 300);
  ctx.lineTo(180, 200);
  ctx.lineTo(350, 200);
  ctx.lineTo(350, 300);
  ctx.strokeStyle = "black";
  ctx.lineWidth = 3;
  ctx.stroke();
  //ctx.closePath();
  ctx.beginPath();
  ctx.strokeStyle = "red";
  ctx.arc(x, 400, 50, 0, 2 * Math.PI);
  ctx.closePath();
}
