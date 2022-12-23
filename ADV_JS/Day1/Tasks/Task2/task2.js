var reversedCollection1 = function () {
  var arr = [];
  arr.reverse.call(arguments);
  return arguments;
};

console.log(reversedCollection1(1, 3, 5, 7, 9, 11, 12));

var reversedCollection2 = function () {
  var arr = Array.from(arguments);
  arr.reverse();
  return arr;
};

console.log(reversedCollection2(1, 3, 4, 5, 6, 6, 7, 7, 8, 9));

var reversedCollection3 = function () {
  var arr = [];
  return arr.reverse.bind(arguments)();
};

console.log(reversedCollection3(1, 3, 4, 5, 6, 7, 8, 9));
