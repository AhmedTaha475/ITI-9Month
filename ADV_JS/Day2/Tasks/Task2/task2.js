function Rectangle(myWidth = 0, myHeight = 0) {
  this.width = myWidth;
  this.height = myHeight;
  this.area = function () {
    return this.width * this.height;
  };
  this.perimeter = function () {
    return (this.width + this.height) * 2;
  };
  this.displayInfo = function () {
    console.log(
      "Width=" +
        this.width +
        "/ Height=" +
        this.height +
        "/ Area=" +
        this.area() +
        "/ Perimeter=" +
        this.perimeter()
    );
  };
}

var r1 = new Rectangle(5, 4);
console.log(r1.area());
console.log(r1.perimeter());
console.log("------------------------------");
r1.displayInfo();
