var answer = document.getElementById("Answer");
var parameter1 = null,
  parameter2 = null;
var operatorType = null;
var result = 0;
var array = [];
function EnterNumber(value) {
  answer.value += value;
}
function EnterOperator(value) {
  parameter1 = answer.value;
  answer.value = "";
  operatorType = value;
}

function EnterClear() {
  answer.value = "";
}

function EnterEqual() {
  parameter2 = answer.value;
  switch (operatorType) {
    case "+":
      answer.value = parseFloat(parameter1) + parseFloat(parameter2);
      break;
    case "*":
      answer.value = parameter1 * parameter2;
      break;
    case "/":
      answer.value = parameter1 / parameter2;
      break;
    case "-":
      answer.value = parameter1 - parameter2;
      break;
  }
}
