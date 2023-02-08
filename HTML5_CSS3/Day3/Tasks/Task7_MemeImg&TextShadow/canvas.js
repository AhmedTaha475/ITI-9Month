var canvas = document.getElementById("c1");
var ctx = canvas.getContext("2d");

var img = new Image();
img.src = "haaa.jpg";
img.onload = function () {
  ctx.drawImage(img, 0, 0, 500, 500);

  ctx.font = "30px arial";
  ctx.fillStyle = "white";
  ctx.fillText("مالك يا طه قلقان ليه ", 160, 400);
  ctx.fillStyle = "rgba(255,255,255,0.4)";
  ctx.fillText("مالك يا طه قلقان ليه ", 164, 404);
  ctx.font = "22px arial";
  ctx.fillStyle = "white";
  ctx.fillText(" دنا هموت قاعد فى التاسك بقالى 4 ساعات مش راضى يخلص", 25, 450);
  ctx.fillStyle = "rgba(255,255,255,0.4)";
  ctx.fillText(" دنا هموت قاعد فى التاسك بقالى 4 ساعات مش راضى يخلص", 29, 454);
};
