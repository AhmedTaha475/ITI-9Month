var canvas = document.getElementById("c1");
var ctx = canvas.getContext("2d");
var angle = 0;
var flag = true;
window.setInterval(function () {
  if (flag) {
    ctx.save();
    ctx.fillStyle = "#FF0000";

    ctx.translate(250, 250); // First translate the context to the center you wish to rotate around.
    ctx.rotate((angle * Math.PI) / 360); // Then do the actual rotation.
    ctx.translate(-250, -250); // Then translate the context back.

    ctx.beginPath();
    ctx.fillStyle = "rgba(0,0,255,0.4)";
    ctx.fillRect(250, 250, 100, 20);
    ctx.closePath();

    ctx.restore();
    angle = angle - 60;
  } else if (!flag) {
    ctx.save();
    ctx.fillStyle = "#FF0000";

    ctx.translate(250, 250); // First translate the context to the center you wish to rotate around.
    ctx.rotate((angle * Math.PI) / 360); // Then do the actual rotation.
    ctx.translate(-250, -250); // Then translate the context back.

    ctx.beginPath();
    ctx.fillStyle = "rgba(0,0,255,0.4)";
    ctx.fillRect(250, 250, 100, 20);
    ctx.closePath();

    ctx.restore();
    angle = angle + 60;
  }

  if (angle == 780) {
    flag = true;
    angle = 0;
    ctx.clearRect(0, 0, canvas.width, canvas.height);
  } else if (angle == -780) {
    flag = false;
    angle = 0;
    ctx.clearRect(0, 0, canvas.width, canvas.height);
  }
}, 80);
