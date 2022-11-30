


var temp,flag=false;
var arry=[];

function openChild()
{
    var i =0;
    temp=open("child.html","","width=500,height=500");
    temp.focus();
    var Message="Your message will be displayed char by char here :).......... few seconds and this window will terminate..............................";
     arry=Message.split("");
    
        var stopInterval=setInterval(() => {
            temp.document.write(arry[i]);
            i++;
            if(i==arry.length)
            {
                clearInterval(stopInterval);
                setTimeout(function(){
                    temp.close();
                },2500);
            }
        }, 50);

    
}
