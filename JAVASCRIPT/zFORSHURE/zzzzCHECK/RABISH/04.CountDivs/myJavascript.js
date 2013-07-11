
window.onload = function()
{
	var submit = document.getElementById("checkButton");
    var result = document.getElementById("result");
	submit.onclick = function ()
	{
        var divs = document.getElementsByTagName("div");
        
        writeLine("There are " + divs.length + " div tags on this page.");
        
	};
};
function writeLine(input)
{
    result.innerHTML = result.innerHTML + input + "<br />";
}

