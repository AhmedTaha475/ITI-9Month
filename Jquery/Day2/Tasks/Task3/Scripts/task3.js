$("#holder").draggable();
$("#dropped").droppable({
  drop: function () {
    $("#holder").hide("explode", 1000);
  },
});
