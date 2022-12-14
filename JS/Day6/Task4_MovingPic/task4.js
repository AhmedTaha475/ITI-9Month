var leftImg = document.getElementById("left");
var rightImg = document.getElementById("right");
var botImg = document.getElementById("top");

var toggleBtn = document.getElementById("toggleBtn");
var resetBtn = document.getElementById("resetBtn");
var stopInterval = null;
var leftFlag = false,
  rightFlag = false,
  botFlag = false;
toggleBtn.addEventListener("click", function () {
  if (toggleBtn.value == "Go") {
    toggleBtn.value = "Stop";
    stopInterval = setInterval(() => {
      // for left img
      if (!leftFlag) {
        leftImg.style.left =
          parseInt(getComputedStyle(leftImg).left) + 10 + "px";
        if (parseInt(getComputedStyle(leftImg).left) == 660) {
          leftFlag = true;
        }
      } else {
        leftImg.style.left =
          parseInt(getComputedStyle(leftImg).left) - 10 + "px";
        if (parseInt(getComputedStyle(leftImg).left) == 0) {
          leftFlag = false;
        }
      }

      //------------------------------------------------------------------

      //for right img

      if (!rightFlag) {
        rightImg.style.right =
          parseInt(getComputedStyle(rightImg).right) + 10 + "px";
        if (parseInt(getComputedStyle(rightImg).right) == 660) {
          rightFlag = true;
        }
      } else {
        rightImg.style.right =
          parseInt(getComputedStyle(rightImg).right) - 10 + "px";
        if (parseInt(getComputedStyle(rightImg).right) == 0) {
          rightFlag = false;
        }
      }

      //For top Image

      if (!botFlag) {
        botImg.style.bottom =
          parseInt(getComputedStyle(botImg).bottom) + 10 + "px";
        if (parseInt(getComputedStyle(botImg).bottom) == 660) {
          botFlag = true;
        }
      } else {
        botImg.style.bottom =
          parseInt(getComputedStyle(botImg).bottom) - 10 + "px";
        if (parseInt(getComputedStyle(botImg).bottom) == 0) {
          botFlag = false;
        }
      }
      //-----------------------------------------------------------
      //set the value of the p lines
      document.getElementById("icon1").innerText =
        '<img src="img/icon1.gif" style="left:' +
        getComputedStyle(leftImg).left +
        '"\\>';

      document.getElementById("icon2").innerText =
        '<img src="img/icon2.gif" style="right:' +
        getComputedStyle(rightImg).right +
        '"\\>';
    }, 10);
  } else if ((toggleBtn.value = "Stop")) {
    clearInterval(stopInterval);
    toggleBtn.value = "Go";
  }
});

resetBtn.addEventListener("click", function () {
  clearInterval(stopInterval);
  leftImg.style.left = 0;
  rightImg.style.right = 0;
  botImg.style.bottom = 0;
  leftFlag = rightFlag = botFlag = false;
  toggleBtn.value = "Go";
  document.getElementById("icon1").innerText =
    '<img src="img/icon1.gif" style="left:' +
    getComputedStyle(leftImg).left +
    '"\\>';
  document.getElementById("icon2").innerText =
    '<img src="img/icon2.gif" style="right:' +
    getComputedStyle(rightImg).right +
    '"\\>';
});
