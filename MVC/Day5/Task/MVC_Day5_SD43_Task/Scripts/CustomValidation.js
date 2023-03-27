
$.validator.addMethod("customannotation", function (value, element, params) {

    if (value == null)
        return true;

    var myname = value.toString();
    if (myname != "AhmedTT")
        return true
    else
        return false;

}, "Please enter the correct Name");


$.validator.unobtrusive.adapters.add("customannotation", [], function (options) {
    options.rules["customannotation"] = true;
    options.messages["customannotation"] = options.message;
});