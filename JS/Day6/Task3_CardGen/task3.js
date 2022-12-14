var inputs = document.getElementsByName("card");
var imgValue = "img/gws.jpg";
var genBtn = document.getElementById("genBtn");
var tareaValue = "";
//get the value of the img
for (var i = 0; i < inputs.length; i++) {
  inputs[i].onchange = function () {
    imgValue = this.value;
  };
}

//get the value of the text-area
genBtn.onclick = function () {
  tareaValue = document.getElementById("tArea").value;
  var flyWindow = open("", "", "width=600px,height=700px");

  var newImg = document.createElement("img");
  //append http:localhost:5500+/+ imgsrc to make it appear on the onthefly window
  newImg.setAttribute("src", location.origin + "/" + imgValue);
  //newImg.setAttribute("src", imgValue);
  newImg.setAttribute("width", "600px");
  newImg.setAttribute("height", "400px");
  flyWindow.document.body.append(newImg);

  var text = document.createElement("h2");
  text.setAttribute("style", "text-align:center;color:blue");
  text.append(tareaValue);
  flyWindow.document.body.append(text);
  flyWindow.document.body.setAttribute("style", "text-align:center");

  var closeBtn = document.createElement("input");
  closeBtn.setAttribute("type", "button");
  closeBtn.setAttribute("value", "Close Window");
  closeBtn.setAttribute("onclick", "closeWindow()");
  flyWindow.document.body.append(closeBtn);

  //create script tag to execute the close button function
  var scriptTag = document.createElement("script");
  scriptTag.append("function closeWindow(){window.close();};");
  flyWindow.document.body.append(scriptTag);
};
