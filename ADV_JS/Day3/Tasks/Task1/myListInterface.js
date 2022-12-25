var listObject = function (_start = 0, _end = 0, _step = 0) {
  var list = [];
  Object.defineProperty(this, "Start", {
    value: _start,
  });
  Object.defineProperty(this, "End", {
    value: _end,
  });
  Object.defineProperty(this, "Step", {
    value: _step,
  });
  this.toString = function () {
    var x = "";
    for (var i = 0; i < list.length; i++) {
      x += list[i] + " ";
    }
    console.log(x);
  };

  this.setList = function () {
    for (var i = _start; i <= _end; i += _step) {
      list.push(i);
    }
  };
  this.getlist = function () {
    return list;
  };

  this.append = function (val) {
    if (list.length == 0) {
      if (val == _start || val == _end || val % _step == 0) {
        list.push(val);
      } else {
        throw new Error("this value is out of sequence");
      }
    } else {
      if (val <= _end && val % _step == 0 && val > list[list.length - 1]) {
        list.push(val);
      } else {
        throw new Error("this value is out of sequence");
      }
    }
  };

  this.prepend = function (val) {
    if (list.length == 0) {
      if (val == _start || val == _end || val % _step == 0) {
        list.unshift(val);
      } else {
        throw new Error("this value is out of sequence");
      }
    } else {
      if (val >= _start && val % _step == 0 && val < list[0]) {
        list.unshift(val);
      } else {
        throw new Error("this value is out of sequence");
      }
    }
  };

  this.pop = function () {
    list.pop();
  };
  this.Dequeue = function () {
    list.shift();
  };

  //Object.seal(this);
  Object.freeze(this);
};

var l1 = new listObject(0, 10, 2);
console.log("Trying to delete properties");
console.log(delete l1.Start);
console.log(delete l1.End);
console.log(delete l1.Step);
console.log("--------------------------------- Adding with append 4,6,8,10");
l1.append(4);
l1.append(6);
l1.append(8);
l1.append(10);
console.log(l1.getlist());
console.log("---------------------------------------- Adding with prepend");
l1.prepend(2);
l1.prepend(0);
console.log(l1.getlist());
console.log("------------------------------------------ using Pop twice");
l1.pop();
l1.pop();
console.log(l1.getlist());
console.log("-------------------------------------------- using dequeue twice");
l1.Dequeue();
l1.Dequeue();
console.log(l1.getlist());
console.log("------------------------------------------------------");

var l2 = new listObject(0, 10, 2);
l2.setList();
console.log(
  "Filling another array with set method and using to string to show"
);
l2.toString();
delete l1.append;
delete l1.prepend;
delete l1.pop;
console.log(Object.keys(l1));
console.log(
  "No property/method can be deleted because of object.seal(this) which is invoked from object.freeze(this) or even create new property"
);
console.log("------------------------------------------------------");
console.log(
  "you can't modify any property/method because of object.freeze(this)"
);
console.log("------------------------------------------------------");
console.log(
  "And in the end i will show you and error occured due to putting value out of sequence"
);
l1.append(9);
