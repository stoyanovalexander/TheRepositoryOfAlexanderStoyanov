

window.onload = function()
{
	var submit = document.getElementById("checkButton");
	var field1 = document.getElementById("inputField1")
    var result = document.getElementById("result");
	submit.onclick = function ()
	{
        var str1 = field1.value;
        writeLine(getLastDigit(str1));
        
        
        
	};
};
function writeLine(input)
{
    result.innerHTML = result.innerHTML + input + "<br />";
}

function getLastDigit(number)
{
	var digit = parseInt(number[number.length - 1]);
	var word = "";
	
	switch(digit)
	{
		case 1:
			word = "one";
			break;
		case 2:
			word = "two";
			break;
		case 3:
			word = "three";
			break;
		case 4:
			word = "four";
			break;
		case 5:
			word = "five";
			break;
		case 6:
			word = "six";
			break;
		case 7:
			word = "seven";
			break;
		case 8:
			word = "eight";
			break;
		case 8:
			word = "nine";
			break;
		case 0:
			word = "zero";
			break;
	}
	
	return word;
}
