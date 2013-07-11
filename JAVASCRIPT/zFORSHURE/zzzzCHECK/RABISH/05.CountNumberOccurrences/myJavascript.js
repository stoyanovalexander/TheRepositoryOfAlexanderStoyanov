
window.onload = function()
{
	var submit = document.getElementById("checkButton");
	var field1 = document.getElementById("inputField1");
	var field2 = document.getElementById("inputField2");
    var result = document.getElementById("result");
	submit.onclick = function ()
	{
        var array = field1.value.split(",");
        var number = field2.value;
        
        writeLine("The number " + number + " was found " + countOccurrence(array, number) + " times in the giver array.");
        
	};
};
function writeLine(input)
{
    result.innerHTML = result.innerHTML + input + "<br />";
}

function countOccurrence(array, number)
{
	var count = 0;
	
	for (var i = 0; i < array.length; i++)
	{
		if (array[i] == number)
		{
			count++;
		}
	}
	
	return count;
}


