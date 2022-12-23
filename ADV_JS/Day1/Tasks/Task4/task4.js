function addNumbers() {
  if (arguments.length == 0) {
    throw new Error("Enter parameters");
  } else {
    for (var i = 0; i < arguments.length; i++) {
      if (typeof arguments[i] != "number") {
        throw new Error("Please enter valid data");
      }
    }

    var sum = 0;
    for (var i = 0; i < arguments.length; i++) {
      sum += arguments[i];
    }
    return sum;
  }
}
