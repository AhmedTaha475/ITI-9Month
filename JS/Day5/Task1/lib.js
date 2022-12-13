function allCookieList() {
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

function getCookie(cookieName) {
  if (hasCookie(cookieName)) {
    var value = allCookieList()[cookieName];
    return value;
  }
  return -1;
}

function hasCookie(cookieName) {
  var reg = new RegExp(cookieName, "igm");
  if (reg.test(document.cookie)) {
    return true;
  }
  return false;
}

function setCookie(cookiName, cookieValue, exprDate = null) {
  if (exprDate == null) {
    document.cookie = cookiName + "=" + cookieValue;
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

function deleteCookie(cookieName) {
  if (hasCookie(cookieName)) {
    setCookie(cookieName, "", 0);
  } else {
    return -1;
  }
}
