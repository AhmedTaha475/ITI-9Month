document.body.firstElementChild.setAttribute("style", "height:100%");

//adjust the first img to the top right
var myHeader = document.body.firstElementChild.firstElementChild;
myHeader.setAttribute("style", "text-align:right;height:33%");

//create new img at the bottom left  as the last element
var footerElement = document.createElement("div");
footerElement.setAttribute(
  "style",
  "height:33%;text-align:left;position:relative"
);
var childElement = document.createElement("img");
childElement.setAttribute("src", "img/dom.jpg");
childElement.setAttribute("style", "position:absolute;bottom:0;");
footerElement.append(childElement);
document.body.firstElementChild.append(footerElement);
var menu = document.body.firstElementChild.firstElementChild.nextElementSibling;
menu.setAttribute("style", "height:33%;");

// adjust the list style type to circle instead of disc
var list = menu.firstElementChild;
list.setAttribute("style", "list-style-type: circle;");
//menu.setAttribute("style", "position:absolute;top:50%;left:50%");
// var menu2 =
//   document.body.firstElementChild.firstElementChild.firstElementChild.cloneNode(
//     true
//   );
