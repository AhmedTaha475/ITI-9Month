var arr = [1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6];
var randomSeq = arr.sort((a, b) => 0.5 - Math.random());
var imgs = document.getElementsByTagName("img");
var temp1 = null;
var temp2 = null;
var counter = 0;
var winCounter = 0;
var test = "";
// if you put var x it will result in the same picture for all images
//because its the same variable that will be in the function after the loop
// because its global scope and function won't read it untill user clicks on it
//so we use let so x is different variable for each function with different values
for (var i = 0; i < imgs.length; i++) {
  let x = randomSeq[i];
  imgs[i].onclick = function () {
    var reg = /(img\/moon.gif)/i;
    if (reg.test(this.src)) {
      this.src = "img/" + x + ".gif";
      counter++;
      if (counter == 1) {
        temp1 = this;
      } else if (counter == 2) {
        temp2 = this;
        if (temp2.src != temp1.src) {
          setTimeout(() => {
            temp1.src = "img/Moon.gif";
            temp2.src = "img/Moon.gif";
            counter = 0;
          }, 500);
        } else {
          winCounter++;
          counter = 0;
          if (winCounter == 6) {
            alert("Congratulations");
          }
        }
      }
    }
  };
}
