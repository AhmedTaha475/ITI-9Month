/*1.1 Write a script that accepts a string from user through prompt and 
count the number of a specific character that the user will define in 
another prompt. Ask the user whether to consider difference between 
letter cases or not then display the number of letter appearance.
*/

function enterText()
{
var userString,searchString,caseSen,tempArry=[];
 userString = prompt("Enter String Here");
 searchString=prompt("Enter the searchString");
 caseSen = confirm("Do you want it to be Case sensitive or not ? ");

    if(caseSen)
    {
        tempArry=userString.trim().split(searchString);
        
    }
    else
    {
        var Reg=new RegExp(searchString,"gi");
        tempArry=userString.trim().split(Reg);
        
    }
    //console.log (tempArry.length-1);
    var x =tempArry.length-1;
    alert("the count is " + x);
    
}

//enterText();


function palindrome()
{
var userString,caseSen,revArray="";
userString=prompt("Please enter your string");
caseSen=confirm("Do you want it be Case sensitive or not ?")
if(caseSen)
{
    for(var i=userString.length-1;i>=(userString.length)/2;i--)
    {
        revArray+=userString[i];
    }
 if(revArray==userString.substring(0,(userString.length)/2))   
    {
        alert("This word is palindrome");
    }
    else
    {
        alert("Not palindrome ");
    }
}else
{
    for(var i=userString.length-1;i>=(userString.length)/2;i--)
    {
        revArray+=userString[i].toLowerCase();
    }
    if(revArray==userString.substring(0,(userString.length)/2).toLowerCase())   
    {
        alert("This word is palindrome");
    }
    else
    {
        alert("Not palindrome ");
    }
}

}

//palindrome();


function checkLength()
{
var tempArry=[],index,wordLength=0;
var userString=prompt("Enter String");
userString=userString.trim();
tempArry=userString.split(" ");

for(var i = 0;i<tempArry.length;i++)
{
    if(tempArry[i].length>wordLength)
    {
        index=i;
        wordLength=tempArry[i].length;
    }
}


alert(tempArry[index]);

}
//CheckLength();



function getInfo()
{
var reg=/^[a-zA-Z]{0,}$/
 do
 {
    var name=prompt("Enter Name");
 }while(!reg.test(name))   

 reg=/^[0-9]{8}$/;
 do
 {
    var phone=prompt("Enter phone");
 }while(!reg.test(phone)) 

reg=/^(010|011|012)[0-9]{8}$/;


do
{
   var mobile=prompt("Enter Mobile Phone");
}while(!reg.test(mobile)) 

reg=/^[a-zA-Z0-9]{3,10}\@[a-zA-Z0-9]{3,10}(.com)$/;


do
{
   var Email=prompt("Enter Email");
}while(!reg.test(Email))

var Mycolor=prompt("Choose Color : Red Green Blue");

document.write("<span style='color:" +Mycolor+ "'> Welcome dear guest </span>"+name);
document.write("<br> <span style='color:" +Mycolor+ "'> Your telephone number is  </span>"+phone);
document.write("<br><span style='color:" +Mycolor+ "'> your mobile number is </span>"+mobile);
document.write("<br><span style='color:" +Mycolor+ "'> your email address is </span>"+Email);




}

//getInfo();