function countParameters(a, b) {
  if (arguments.length != countParameters.length) {
    throw new Error("Different numbers of parameters");
  } else {
    console.log("Perfect number of parameters");
  }
}
