var canvas = document.getElementById("c1");
var ctx = canvas.getContext("2d");

var radialGradient1 = ctx.createRadialGradient(200, 200, 100, 200, 200, 150);
radialGradient1.addColorStop(0, "white");
radialGradient1.addColorStop(0.7, "white");
radialGradient1.addColorStop(0.9, "blue");
radialGradient1.addColorStop(1, "blue");
var radialGradient2 = ctx.createRadialGradient(200, 200, 100, 200, 200, 150);
radialGradient2.addColorStop(0, "blue");
radialGradient2.addColorStop(0.7, "white");
radialGradient2.addColorStop(0.9, "blue");
radialGradient2.addColorStop(1, "white");
ctx.fillStyle = radialGradient2;
ctx.arc(200, 200, 150, 0, 2 * Math.PI);
ctx.fill();

ctx.strokeStyle = radialGradient1;
ctx.lineWidth = 16;
ctx.arc(200, 200, 150, 0, 2 * Math.PI);
ctx.stroke();

ctx.beginPath();

ctx.fillStyle = "white";
ctx.font = "200px arial";
ctx.fillText("A", 140, 260, 150);
