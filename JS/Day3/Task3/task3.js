// creating parent window and child window floating across parent window
var temp,stopInterval;
function openChild()
{
    var x=0,y=0,flag=false;
    temp=open("child.html","","width=100,height=100");
    temp.focus();


     stopInterval=setInterval(function() {
        if(!flag)
        {
            x+=75;
            y+=75;
        }
        else
        {
            x-=75;
            y-=75;
        }
        console.log("X is : " + x);
        console.log("Y is : " + y);
        temp.moveTo(x,y);
        if(!flag)
        {
            if(x>=(innerWidth-75)||y>=(innerHeight-75))
            {
                
                flag=true;
            }
        }
        else
        {
            if(x<=0||y<=0)
            {
               
                flag=false;
            }
        }

    }, 200);
}


function closeChild()
{
    temp.close();
    clearInterval(stopInterval);
}

//--------------------------------------------------------

