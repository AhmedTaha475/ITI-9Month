$(function () {
  $("button").click(function () {
    if ($(this).attr("id") == "about") {
      $(".content").hide();
      $("#aboutPg")
        .css({
          width: "500px",
          height: "300px",
          margin: "50px auto",
          boxShadow: "-1px -1px 15px 1px black",
          textAlign: "center",
        })
        .fadeIn()
        .html("<p>Story about snow man</p>");
    } else if ($(this).attr("id") == "gallery") {
      $(".content").hide();
      //#region implement gallery Div
      $("#galleryPg")
        .html(
          '<img src="" width="50px" height="40px" alt="" id="left">' +
            '<img src="" width="400px" height="350px" alt="" id="mainImg">' +
            '<img src="" width="50px" height="40px" alt="" id="right">'
        )
        .css({ marginTop: "50px", textAlign: "center", position: "relative" });
      $("#left")
        .css({ position: "absolute", top: "48%", left: "32%" })
        .attr("src", "../Images/left.png");
      $("#right")
        .css({ position: "absolute", top: "48%", right: "32%" })
        .attr("src", "../Images/right.png");
      $("#mainImg").attr("src", "../Images/1.jpg");
      $("#galleryPg").fadeIn();
      //#endregion
      //#region sliderMethods
      var counter = 1;
      $("#left,#right").click(function () {
        //console.log("hi");
        var imgSrc = "";
        if ($(this).attr("id") == "left") {
          counter--;
          if (counter == 0) {
            counter = 8;
          }
          //   //"../Images/1.jpg"
          imgSrc = "../Images/" + counter + ".jpg";
          $("#mainImg").attr("src", imgSrc);
        } else if ($(this).attr("id") == "right") {
          counter++;
          if (counter == 9) counter = 1;
          imgSrc = "../Images/" + counter + ".jpg";
          $("#mainImg").attr("src", imgSrc);
        }
      });

      //#endregion
    } else if ($(this).attr("id") == "services") {
      $(".content").hide();
      //#region implement service Div
      $("#servicesPg")
        .html('<ul id="list"><li>item1</li><li>item2</li><li>item3</li></ul>')
        .css("position", "relative");
      $("#list").css({
        position: "absolute",
        left: "47%",
        listStyleType: "none",
        marginTop: "5px",
      });
      $("#list li").css({
        backgroundColor: "rgb(247, 55, 135)",
        padding: "15px 50px",
        border: "1px solid rgb(252, 88, 156)",
        borderRadius: "10px",
        color: "white",
      });
      $("#list").hide();
      $("#servicesPg").show(function () {
        $("#list").slideDown(2000);
      });
      //#endregion
    } else {
      $(".content").hide();
      //#region impleminting First Page
      $("#complainPg")
        .html(
          `<div id="firstDiv">
          <label for="nameInp">
              Name:
              <input type="text" name="name" id="nameInp">
          </label>
          <br><br>

          <label for="emailInp">
              Email:
              <input type="text" name="email" id="emailInp">
          </label>
          <br><br>
          <label for="phoneInp">
              Phone:
              <input type="text" name="phone" id="phoneInp">
          </label>
          <br><br>
          <label for="areaInp">
              Complain:
          </label>
          <br>
          <textarea name="complain" id="areaInp" cols="30" rows="10"></textarea>
          <br>
          <button id="sendData">Send</button>
      </div>
      <div id="secondDiv">
          <p>your Complain is <span id="myComplain"></span></p>
          <br>
          <p>Your Name is <span id="myName"></span></p>
          <br>
          <p>your Email is <span id="myEmail"></span></p>
          <br>
          <p>Your Phone is <span id="myPhone"></span></p>
          <br>
          <button id="returnData"> Back to Edit</button>
      </div>`
        )
        .css({
          width: "500px",
          height: "300px",
          margin: "50px auto",
          boxShadow: "0px 0px 9px 1px grey",
          textAlign: "center",
          padding: "50px",
        });
      $("#firstDiv,#secondDiv").hide();
      $("#complainPg").show(function () {
        $("#firstDiv").fadeIn(1000);
        $("#sendData").click(function () {
          $("#myName").text($("#nameInp").val()).css("color", "red");
          $("#myEmail").text($("#emailInp").val()).css("color", "red");
          $("#myPhone").text($("#phoneInp").val()).css("color", "red");
          $("#myComplain").text($("#areaInp").val()).css("color", "red");
          $("#firstDiv").hide();
          $("#secondDiv").fadeIn(1000);
        });
        $("#returnData").click(function () {
          $("#secondDiv").hide(500);
          $("#firstDiv").show(1000);
        });
      });
      //#endregion
    }
  });
});
