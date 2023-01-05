$(function () {
  $.ajax({
    method: "GET",
    url: "../Data/rockbands.json",
    data: {},
    success: function (myData) {
      for (var i in myData) {
        $("#cat").append("<option value='" + i + "'>" + i + "</option>");
      }

      $("#cat").on("change", function () {
        $("#data").html("");
        $("#data").append("<option value=''></option>");
        myData[$("#Cat").val()];
        var x = myData[$("#cat").val()];
        $("");
        for (var i in x) {
          $("#data").append(
            "<option value='" + x[i].value + "'>" + x[i].name + "</option>"
          );
        }
        $("#data").on("change", function () {
          if ($("#data").val() != "") {
            window.open($("#data").val(), "popup");
          }
        });
      });
    },
  });
});
