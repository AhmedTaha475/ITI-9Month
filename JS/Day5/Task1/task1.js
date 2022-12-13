var regBtn = document.getElementById("regBtn");
var uName = document.getElementById("uName");
var uAge = document.getElementById("uAge");
var myMale = document.getElementById("myMale");
var myFemale = document.getElementById("myFemale");
var myColor = document.getElementById("color");
regBtn.onclick = function () {
  setCookie("userName", uName.value, "10/25/2030");
  setCookie("userAge", uAge.value, "10/25/2030");
  if (myMale.checked) {
    setCookie("userGender", myMale.value, "10/25/2030");
  } else if (myFemale.checked) {
    setCookie("userGender", myFemale.value, "10/25/2030");
  }
  setCookie("userColor", myColor.value, "10/25/2030");

  setCookie("visits", 0);

  location.assign("home.html");
};
