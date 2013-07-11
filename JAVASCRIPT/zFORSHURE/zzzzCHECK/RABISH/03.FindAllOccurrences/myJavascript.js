
window.onload = function()
{
	var submit = document.getElementById("checkButton");
	var field1 = document.getElementById("inputField1");
	var field2 = document.getElementById("inputField2");
	var field3 = document.getElementById("inputField3");
    var result = document.getElementById("result");
	submit.onclick = function ()
	{
        var text = field1.value;
        var word = field2.value;
        var searchType = field3.value;
        
        var result = searchWord(text, word, searchType);
        writeLine(result);
        
	};
};
function writeLine(input)
{
    result.innerHTML = result.innerHTML + input + "<br />";
}

function searchWord(text, word, searchType)
{
	var searchType = searchType || 0;
	var count = 0;
	if (searchType == false)
	{
		var i = text.toLowerCase().indexOf(word);
		while (i >= 0)
		{
			count++;
			i = text.toLowerCase().indexOf(word, ++i);
		}
	}
	else
	{
		var i = text.indexOf(word);
		while (i >= 0)
		{
			count++;
			i = text.indexOf(word, ++i);
		}
	}
	
	return count;
}
