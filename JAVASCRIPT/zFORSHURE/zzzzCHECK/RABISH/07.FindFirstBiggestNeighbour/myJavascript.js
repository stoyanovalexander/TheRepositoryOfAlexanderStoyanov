
window.onload = function()
{
	var submit = document.getElementById("checkButton");
	var field1 = document.getElementById("inputField1");
    var result = document.getElementById("result");
	submit.onclick = function ()
	{
        var array = field1.value.split(",");
        
        writeLine("First biggest number was at position: " + findFirstBiggestNeighbour(array));
        
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

function findFirstBiggestNeighbour(array)
{
	var index = 1;
	
	for (var i = 0; i < array.length - 1; i++)
	{
		if (compareNeighbours(array, index))
		{
			return index;
		}
		index++;
	}
	
	return -1;
}


