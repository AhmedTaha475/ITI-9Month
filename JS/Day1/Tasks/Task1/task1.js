
function printText()
{
    var result = prompt("enter message");

    for (var i =1;i<=6;i++)
    {

        //document.write(`<h${i+1}>${result}<h${i+1}>`);
        document.write("<h"+i+">"+result+"</h"+i+">");
    }
}



//printText();




function Sum()
{
    var sum=0;
        
    do
    {
           var number=parseInt(prompt("Enter value"));
           if(isFinite(number))
           {
               sum+=number;

           }

    }
    while(sum<100 && number!==0)
    
    document.write("Sum is :"+sum);
    

}

Sum();
