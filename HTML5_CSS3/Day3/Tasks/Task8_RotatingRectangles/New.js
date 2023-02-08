// Code to illustrate rotation of a shape around any given point. The important functions here is rotateAroundPoint() which does the rotation and movement math !

let angle = 0, // display value of angle
  startPos = { x: 80, y: 45 },
  shapes = [], // array of shape ghosts / tails
  rotateBy = 20, // per-step angle of rotation
  shapeName = $("#shapeName").val(), // what shape are we drawing
  shape = null,
  ghostLimit = 10,
  // Set up a stage
  stage = new Konva.Stage({
    container: "container",
    width: window.innerWidth,
    height: window.innerHeight,
  }),
  // add a layer to draw on
  layer = new Konva.Layer(),
  // create the rotation target point cross-hair marker
  lineV = new Konva.Line({
    points: [0, -20, 0, 20],
    stroke: "cyan",
    strokeWidth: 1,
  }),
  lineH = new Konva.Line({
    points: [-20, 0, 20, 0],
    stroke: "cyan",
    strokeWidth: 1,
  }),
  circle = new Konva.Circle({
    x: 0,
    y: 0,
    radius: 10,
    fill: "transparent",
    stroke: "cyan",
    strokeWidth: 1,
  }),
  cross = new Konva.Group({ draggable: true, x: startPos.x, y: startPos.y });

// Add the elements to the cross-hair group
cross.add(lineV, lineH, circle);
layer.add(cross);

// Add the layer to the stage
stage.add(layer);

// If the user changes the shape select, react.
$("#shapeName").on("change", function () {
  shapeName = $("#shapeName").val();
  shape.destroy();
  shape = null;
  reset();
});

// Draw whatever shape the user selected
function drawShape() {
  // Add a shape to rotate
  if (shape !== null) {
    shape.destroy();
  }

  switch (shapeName) {
    case "rectangle":
      shape = new Konva.Rect({
        x: startPos.x,
        y: startPos.y,
        width: 120,
        height: 80,
        fill: "magenta",
        stroke: "black",
        strokeWidth: 4,
      });
      break;

    case "hexagon":
      shape = new Konva.RegularPolygon({
        x: startPos.x,
        y: startPos.y,
        sides: 6,
        radius: 40,
        fill: "magenta",
        stroke: "black",
        strokeWidth: 4,
      });
      break;

    case "ellipse":
      shape = new Konva.Ellipse({
        x: startPos.x,
        y: startPos.y,
        radiusX: 40,
        radiusY: 20,
        fill: "magenta",
        stroke: "black",
        strokeWidth: 4,
      });
      break;

    case "circle":
      shape = new Konva.Ellipse({
        x: startPos.x,
        y: startPos.y,
        radiusX: 40,
        radiusY: 40,
        fill: "magenta",
        stroke: "black",
        strokeWidth: 4,
      });
      break;

    case "star":
      shape = new Konva.Star({
        x: startPos.x,
        y: startPos.y,
        numPoints: 5,
        innerRadius: 20,
        outerRadius: 40,
        fill: "magenta",
        stroke: "black",
        strokeWidth: 4,
      });
      break;
  }
  layer.add(shape);

  cross.moveToTop();
}

// Reset the shape position etc.
function reset() {
  drawShape(); // draw the current shape

  // Set to starting position, etc.
  shape.position(startPos);
  cross.position(startPos);
  angle = 0;
  $("#angle").html(angle);
  $("#position").html("(" + shape.x() + ", " + shape.y() + ")");

  clearTails(); // clear the tail shapes

  stage.draw(); // refresh / draw the stage.
}

// Click the stage to move the rotation point
stage.on("click", function (e) {
  cross.position(stage.getPointerPosition());
  stage.draw();
});

// Rotate a shape around any point.
// shape is a Konva shape
// angleDegrees is the angle to rotate by, in degrees
// point is an object {x: posX, y: posY}
function rotateAroundPoint(shape, angleDegrees, point) {
  let angleRadians = (angleDegrees * Math.PI) / 180; // sin + cos require radians

  const x =
    point.x +
    (shape.x() - point.x) * Math.cos(angleRadians) -
    (shape.y() - point.y) * Math.sin(angleRadians);
  const y =
    point.y +
    (shape.x() - point.x) * Math.sin(angleRadians) +
    (shape.y() - point.y) * Math.cos(angleRadians);

  shape.position({ x: x, y: y }); // move the rotated shape in relation to the rotation point.
  shape.rotation(shape.rotation() + angleDegrees); // rotate the shape in place around its natural rotation point
}

$("#rotate").on("click", function () {
  let newShape = shape.clone();
  shapes.push(newShape);
  layer.add(newShape);

  // This ghost / tails stuff is just for fun.
  if (shapes.length >= ghostLimit) {
    shapes[0].destroy();
    shapes = shapes.slice(1);
  }
  for (var i = shapes.length - 1; i >= 0; i--) {
    shapes[i].opacity((i + 1) * (1 / (shapes.length + 2)));
  }

  // This is the important call ! Cross is the rotation point as illustrated by crosshairs.
  rotateAroundPoint(shape, rotateBy, { x: cross.x(), y: cross.y() });

  shape.moveToTop(); // ensure the 'tails' shapes do not cover the main shape

  cross.moveToTop(); // ensure the cross is visible.

  stage.draw();

  angle = angle + 10;
  $("#angle").html(angle);
  $("#position").html(
    "(" +
      Math.round(shape.x() * 10) / 10 +
      ", " +
      Math.round(shape.y() * 10) / 10 +
      ")"
  );
});

// Function to clear the ghost / tail shapes
function clearTails() {
  for (var i = shapes.length - 1; i >= 0; i--) {
    shapes[i].destroy();
  }
  shapes = [];
}

// User cicks the reset button.
$("#reset").on("click", function () {
  reset();
});

// Force first draw!
reset();
