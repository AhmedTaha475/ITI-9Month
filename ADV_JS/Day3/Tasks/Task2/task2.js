//all the properties of book created using data descriptor
var book = function (
  _title,
  _noOfChapters,
  _author,
  _noOfPages,
  _publisher,
  _noOfCopies
) {
  Object.defineProperties(this, {
    title: { value: _title },
    numberOfChapters: { value: _noOfChapters },
    author: { value: _author },
    numberOfPages: { value: _noOfPages },
    publisher: { value: _publisher },
    numberOfCopies: { value: _noOfCopies },
  });
  book.count++;
};
//book class property and methods to deal with the number of book object created
book.count = 0;
book.getCount = function () {
  return book.count;
};
///creating properties using accessor descriptor
///creating method using data descriptor
///overriding toString and valueOf using overriding outside the constructor using .prototype its also available to override inside the constructor
///you can add box1+box2 it will result in the total number of books inside each one of them
///you can get the total number of book from the book static method book.getCount()
var box = function (_height, _width, _length, _material) {
  var content = [];
  Object.defineProperties(this, {
    height: {
      get: function () {
        return _height;
      },
      set: function (val) {
        _height = val;
      },
      enumerable: true,
    },
    width: {
      get: function () {
        return _width;
      },
      set: function (val) {
        _width = val;
      },
      enumerable: true,
    },
    length: {
      get: function () {
        return _length;
      },
      set: function (val) {
        _length = val;
      },
      enumerable: true,
    },
    material: {
      get: function () {
        return _material;
      },
      set: function (val) {
        _material = val;
      },
      enumerable: true,
    },
    content: {
      get: function () {
        return content;
      },
      enumerable: true,
    },
    addBook: {
      value: function (
        _title,
        _noOfChapters,
        _author,
        _noOfPages,
        _publisher,
        _noOfCopies
      ) {
        if (content.length == 0) {
          content.push(
            new book(
              _title,
              _noOfChapters,
              _author,
              _noOfPages,
              _publisher,
              _noOfCopies
            )
          );
          return "Book has been added successfully";
        } else {
          for (var i = 0; i < content.length; i++) {
            if (_title == content[i].title) {
              return "There is already a copy of that book in the box";
            }
          }
          content.push(
            new book(
              _title,
              _noOfChapters,
              _author,
              _noOfPages,
              _publisher,
              _noOfCopies
            )
          );
          return "Book has been added successfully";
        }
      },
      enumerable: true,
    },
    numberOfBooks: {
      get: function () {
        return content.length;
      },
      enumerable: true,
    },
  });

  Object.freeze(this);
};
box.prototype.toString = function () {
  return (
    "Height:" +
    this.height +
    " Width:" +
    this.width +
    " Length:" +
    this.length +
    " Material:" +
    this.material +
    " " +
    this.numberOfBooks +
    " Books are stored above each other"
  );
};
box.prototype.valueOf = function () {
  return this.numberOfBooks;
};

var b1 = new box(50, 60, 60, "wood");
var b2 = new box(90, 100, 60, "paper");
console.log("---------------adding books in b1----------------");
console.log(b1.addBook("title1", 20, "ahmed", 600, "aya7aga", 1000));
console.log("If you add same book with the same title it won't be added");
console.log(b1.addBook("title1", 20, "ahmed", 600, "aya7aga", 1000));
console.log(b1.addBook("title2", 20, "ahmed", 600, "aya7aga", 1000));
console.log(b1.addBook("title3", 20, "ahmed", 600, "aya7aga", 1000));
console.log(b1.addBook("title4", 20, "ahmed", 600, "aya7aga", 1000));
console.log(b1.addBook("title5", 20, "ahmed", 600, "aya7aga", 1000));
console.log(b1.addBook("title6", 20, "ahmed", 600, "aya7aga", 1000));
console.log("---------------adding books ing b2----------------");
console.log(b2.addBook("title1", 20, "ahmed", 600, "aya7aga", 1000));
console.log(b2.addBook("title2", 20, "ahmed", 600, "aya7aga", 1000));
console.log(b2.addBook("title3", 20, "ahmed", 600, "aya7aga", 1000));
console.log("-----------------------------------------------------");
console.log(
  `you can't delete anyproperty or add new one because of object.seal(this) 
  which is invoked from object.freeze(this) which also make any property created with data descriptor non writable`
);
console.log(delete b1.addBook);
console.log("no of books in b1: " + b1.numberOfBooks);
console.log("no of books in b2: " + b2.numberOfBooks);
var x = b1 + b2;
console.log("b1+b2=" + x);
console.log("total no of book object created : " + book.getCount());
