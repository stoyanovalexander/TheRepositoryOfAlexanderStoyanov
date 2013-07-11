
window.onload = function()
{
	var submit = document.getElementById("checkButton");
	var field1 = document.getElementById("inputField1");
	var field2 = document.getElementById("inputField2");
    var result = document.getElementById("result");
	submit.onclick = function ()
	{
        var array = field1.value.split(",");
        var index = field2.value;
        
        if (compareNeighbours(array, index))
        {
        	writeLine("Number at position " + index + "is bigger than its neighbours.");
        }
        else
        {
        	writeLine("Number at position " + index + "is not bigger than its neighbours.");
        }
        
	};
};
function writeLine(input)
{
    result.innerHTML = result.innerHTML + input + "<br />";
}

function compareNeighbours(array, index)
{
	var index = parseInt(index);
	if (index >= 1 && index < array.length - 1)
    {
    	var test2 = array[2];
        if (array[index] > array[index - 1] && array[index] > array[index + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        writeLine("Cannot compare first or last element of the array!");
        return false;
    }
}


