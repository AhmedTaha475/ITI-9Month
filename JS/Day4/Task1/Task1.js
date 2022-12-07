if (document.title == "Reg Form") {
  var myForm = document.getElementById("regForm");
  var flag = false;
  var x = location.search;
  var btn = document.getElementById("subForm");
  for (var i = 0; i < 7; i++) {
    myForm[i].onchange = function () {
      if (this.id == "regName") {
        var reg = /^[a-zA-Z]{5,20}$/;
        if (reg.test(this.value)) {
          flag = true;
          document.getElementById("alertName").hidden = true;
        } else {
          flag = false;
          document.getElementById("alertName").hidden = false;
        }
      } else if (this.id == "regEmail") {
        var reg1 = /^[a-zA-Z0-9]{5,15}\@(yahoo|gmail)\.(com)$/;
        if (reg1.test(this.value)) {
          flag = true;
          document.getElementById("alertMail").hidden = true;
        } else {
          flag = false;
          document.getElementById("alertMail").hidden = false;
        }
      } else if (this.id == "regPassword") {
        var reg2 = /^[A-Z]{1}[a-zA-Z0-9_@]{7,}$/;
        if (reg2.test(this.value)) {
          flag = true;
          document.getElementById("alertPassword").hidden = true;
        } else {
          flag = false;
          document.getElementById("alertPassword").hidden = false;
        }
      } else if (this.id == "regTitle") {
        var reg3 = /^[a-zA-Z]{2,5}$/;
        if (reg3.test(this.value)) {
          flag = true;
          document.getElementById("alertTitle").hidden = true;
        } else {
          flag = false;
          document.getElementById("alertTitle").hidden = false;
        }
      } else if (this.id == "regMobile") {
        var reg4 = /^(011|012|010)[0-9]{8}$/;
        if (reg4.test(this.value)) {
          flag = true;
          document.getElementById("alertMobile").hidden = true;
        } else {
          flag = false;
          document.getElementById("alertMobile").hidden = false;
        }
      } else if (this.id == "regGender") {
        var reg5 = /^(male|female)$/i;
        if (reg5.test(this.value)) {
          flag = true;
          document.getElementById("alertGender").hidden = true;
        } else {
          flag = false;
          document.getElementById("alertGender").hidden = false;
        }
      } else if (this.id == "regAddress") {
        var reg6 = /^[a-zA-Z0-9]{5,}$/;
        if (reg6.test(this.value)) {
          flag = true;
          document.getElementById("alertAddress").hidden = true;
        } else {
          flag = false;
          document.getElementById("alertAddress").hidden = false;
        }
      }
    };
  }

  myForm.onsubmit = function () {
    if (flag) {
      myForm.action = "index.html";
    } else {
      return false;
    }
  };
} else {
  var queryString = location.search;
  var params = new URLSearchParams(queryString);
  document.getElementById("userTitle").innerText = params.get("Title");
  document.getElementById("userName").innerText = params.get("uName");
  document.getElementById("userAddress").innerText = params.get("Address");
  document.getElementById("userGender").innerText = params.get("Gender");
  document.getElementById("userEmail").innerText = params.get("Email");
  document.getElementById("userMobile").innerText = parseInt(
    params.get("Mobile")
  );

  var browserName = navigator.userAgent;
  var reg = /(Chrome\/108)/i;
  if (!reg.test(browserName)) {
    document.getElementById("checkBrowser").hidden = false;
  }
}
