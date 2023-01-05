$("img").animate(
  { left: "1600" },
  {
    duration: 3000,
    step: function (now) {
      $("#type").text(
        '<img src="../Images/12.gif" style="left' + now.toFixed() + '">'
      );
    },
    complete: function () {
      $("img").hide("explode", 3000);
    },
  }
);
