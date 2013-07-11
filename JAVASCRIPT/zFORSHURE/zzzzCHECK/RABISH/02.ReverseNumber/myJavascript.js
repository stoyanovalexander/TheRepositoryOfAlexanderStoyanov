
window.onload = function()
{
	var submit = document.getElementById("checkButton");
	var field1 = document.getElementById("inputField1")
    var result = document.getElementById("result");
	submit.onclick = function ()
	{
        var str1 = field1.value;
        writeLine(reverseNumber(str1));
        
	};
};
function writeLine(input)
{
    result.innerHTML = result.innerHTML + input + "<br />";
}

function reverseNumber(number)
{
	number = number + "";
	var reversedNumber = number.split("").reverse().join("");
	return parseFloat(reversedNumber);
}
