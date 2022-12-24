var generatingobject = {
  description:
    "this object method getSetGen will generate setter and getters for your object properties",
  getSetGen: function () {
    var myObject = this;
    var objEntries = Object.entries(this);
    for (var i = 0; i < objEntries.length; i++) {
      if (typeof objEntries[i][1] != "function") {
        //console.log(objEntries[i][0]);

        (function (j) {
          myObject["set" + objEntries[j][0]] = function (value) {
            myObject[objEntries[j][0]] = value;
          };
          myObject["get" + objEntries[j][0]] = function () {
            return myObject[objEntries[j][0]];
          };
        })(i);
      }
    }
  },
};

var testObj = { name: "ahmed", salary: 512, address: "ay7aga" };

generatingobject.getSetGen.call(testObj);
console.log(testObj.getname());
console.log(testObj.getsalary());
console.log(testObj.getaddress());
console.log("----------------------------------");
testObj.setname("taha");
testObj.setsalary(450000);
testObj.setaddress("changed address");
console.log("-----------------------------------");
console.log(testObj.getname());
console.log(testObj.getsalary());
console.log(testObj.getaddress());
