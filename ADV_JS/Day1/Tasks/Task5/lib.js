function allCookieList() {
  if (arguments.length > 0) {
    throw new Error("Please don't enter any parameters");
  } else {
    if (document.cookie != "") {
      var cookiKeyValue = document.cookie.split(";");
      var KeyValueArr = [];
      var SingleKeyValue = [];
      for (var i = 0; i < cookiKeyValue.length; i++) {
        SingleKeyValue = cookiKeyValue[i].trim().split("=");
        KeyValueArr[SingleKeyValue[0]] = SingleKeyValue[1];
      }

      return KeyValueArr;
    } else return -1;
  }
}

function getCookie(cookieName) {
  if (arguments.length != 1 || typeof arguments[0] != "string") {
    throw new Error("Please enter only one parameter in string formate");
  } else {
    if (hasCookie(cookieName)) {
      var value = allCookieList()[cookieName];
      return value;
    }
    return -1;
  }
}

function hasCookie(cookieName) {
  if (arguments.length != 1 || typeof arguments[0] != "string") {
    throw new Error("Please enter only one parameter in string formate");
  } else {
    var reg = new RegExp(cookieName, "igm");
    if (reg.test(document.cookie)) {
      return true;
    }
    return false;
  }
}

function setCookie(cookiName, cookieValue, exprDate = null) {
  if (arguments.length == 2 || arguments.length == 3) {
    if (exprDate == null) {
      if (typeof cookiName != "string" || typeof cookieValue != "string") {
        throw new Error("Please enter your parameters in string format");
      } else {
        document.cookie = cookiName + "=" + cookieValue;
      }
    } else {
      if (
        typeof cookiName != "string" ||
        typeof exprDate != "string" ||
        typeof cookieValue != "string"
      ) {
        throw new Error("Please enter your parameters in string format");
      } else {
        var myexprDate = new Date(exprDate);
        if (myexprDate == "Invalid Date") {
          document.cookie = cookiName + "=" + cookieValue;
        }
        document.cookie =
          cookiName +
          "=" +
          cookieValue +
          ";" +
          "expires=" +
          myexprDate.toUTCString();
      }
    }
  } else {
    throw new Error("Please enter correct number of parameters");
  }
}

function deleteCookie(cookieName) {
  if (arguments.length != 1 || typeof arguments[0] != "string") {
    throw new Error("Please enter only one parameter in string formate");
  } else {
    if (hasCookie(cookieName)) {
      setCookie(cookieName, "", "0");
    } else {
      return -1;
    }
  }
}
