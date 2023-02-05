var myvideo = document.getElementById("vid"); //done
var play = document.getElementById("play"); //done
var pause = document.getElementById("pause"); //done
var backToStart = document.getElementById("backToStart"); //done
var moveBackStep = document.getElementById("moveBackStep"); //done
var moveForwardStep = document.getElementById("moveForwardStep"); //done
var goToEnd = document.getElementById("goToEnd"); //done
var volumeControl = document.getElementById("volumeControl"); //done
var mute = document.getElementById("mute"); //done
var Speed = document.getElementById("Speed");
var currentDuration = document.getElementById("currentDuration");
var totalDuration = document.getElementById("totalDuration");
var vidDuration = document.getElementById("vidDuration");
var fullScreen = document.getElementById("fullScreen");

play.addEventListener("click", function () {
  myvideo.play();
  totalDuration.innerText = myvideo.duration.toFixed(2);
});
pause.addEventListener("click", function () {
  myvideo.pause();
  totalDuration.innerText = myvideo.duration.toFixed(2);
});
backToStart.addEventListener("click", function () {
  myvideo.currentTime = 0;
  totalDuration.innerText = myvideo.duration.toFixed(2);
});
moveBackStep.addEventListener("click", function () {
  myvideo.currentTime -= 5;
  totalDuration.innerText = myvideo.duration.toFixed(2);
});
moveForwardStep.addEventListener("click", function () {
  myvideo.currentTime += 5;
  totalDuration.innerText = myvideo.duration.toFixed(2);
});
goToEnd.addEventListener("click", function () {
  myvideo.currentTime = myvideo.duration;
  totalDuration.innerText = myvideo.duration.toFixed(2);
});
volumeControl.addEventListener("change", function () {
  myvideo.volume = volumeControl.value;
});
fullScreen.addEventListener("click", function () {
  myvideo.webkitEnterFullscreen();
});
mute.addEventListener("click", function () {
  if (myvideo.muted) {
    myvideo.muted = false;
  } else {
    myvideo.muted = true;
  }
});
Speed.addEventListener("change", function () {
  myvideo.playbackRate = Speed.value;
});
var current = setInterval(function () {
  currentDuration.innerText = myvideo.currentTime.toFixed(2);
  vidDuration.value = myvideo.currentTime.toFixed(0);
}, 10);
