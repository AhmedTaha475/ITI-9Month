var answer = document.getElementById("Answer");
var operatorCounter = 0;
var result = 0;
var array = [];
function EnterNumber(value) {
  answer.value += value;
}
function EnterOperator(value) {
  answer.value += value;
}

function EnterClear() {
  answer.value = "";
}

function EnterEqual() {
  var reg1 = /[+]/i;
  var reg2 = /[*]/i;
  var reg3 = /[/]/i;
  var reg4 = /[-]/i;
  if (reg1.test(answer.value)) {
    array = answer.value.split("+");
    for (var i = 0; i < 2; i++) {
      array[i] = parseFloat(array[i]);
    }
    result = array[0] + array[1];
    answer.value = result;
  } else if (reg2.test(answer.value)) {
    array = answer.value.split("*");
    result = array[0] * array[1];
    answer.value = result;
  } else if (reg3.test(answer.value)) {
    array = answer.value.split("/");
    result = array[0] / array[1];
    answer.value = result;
  } else if (reg4.test(answer.value)) {
    array = answer.value.split("-");
    result = array[0] - array[1];
    answer.value = result;
  } else {
    answer.value = "test";
  }
}
