var form = document.getElementById("myForm");
var stopTime = null;
startTimeOut();

for (var i = 0; i < 3; i++) {
  form[i].addEventListener("keydown", function () {
    clearTimeout(stopTime);
    startTimeOut();
  });
}

function startTimeOut() {
  stopTime = setTimeout(function () {
    alert("You have been timed out");
    for (var i = 0; i < 5; i++) {
      form[i].disabled = true;
    }
  }, 30000);
}

form.addEventListener("submit", function () {
  clearTimeout(stopTime);
  var x = confirm("Do you want to submit ?");
  if (!x) {
    event.preventDefault();
    startTimeOut();
  } else {
    clearTimeout(stopTime);
    event.preventDefault();
    alert("Form Was submitted successfully");
  }
});
