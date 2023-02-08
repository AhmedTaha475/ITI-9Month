// big note i changed the localstorage to localstorage1 and the same for session
// because i can't override them with normal objects for some reason i also tried it with remi polyfill and didnt' manage to override it
//so i created new objects to mimc the process

if (
  typeof window.localStorage == "object" ||
  typeof window.sessionStorage == "object"
)
  (function () {
    var storage = function (type) {
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

      function setCookie(cookieName, cookieValue, exprDate = "5/5/3000") {
        if (type == "session") {
          document.cookie = cookieName + "=" + cookieValue;
        } else if (type == "local") {
          var myexprDate = new Date(exprDate);
          document.cookie =
            cookieName +
            "=" +
            cookieValue +
            ";" +
            "expires=" +
            myexprDate.toUTCString();
        }
      }
      function deleteAllCookies() {
        var cookieArray = allCookieList();
        for (const key in cookieArray) {
          setCookie(key, "", 0);
        }
      }
      function deleteCookie(cookieName) {
        if (hasCookie(cookieName)) {
          setCookie(cookieName, "", 0);
        } else {
          return -1;
        }
      }

      return {
        length: 0,
        setItem: function (cookie, value) {
          setCookie(cookie, value);
        },
        getItem: function (cookie) {
          return getCookie(cookie);
        },
        removeItem: function (cookieName) {
          deleteCookie(cookieName);
        },
        clear: function () {
          deleteAllCookies();
        },
        key: function (i) {
          var counter = 0;
          var cookieArray = allCookieList();
          for (const key in cookieArray) {
            if (counter == i) {
              return cookieArray[key];
            }
            counter++;
          }
        },
      };
    };
    if (typeof window.sessionStorage == "object")
      window.sessionStorage1 = new storage("session");
    if (typeof window.localStorage == "object")
      window.localStorage1 = new storage("local");
  })();
