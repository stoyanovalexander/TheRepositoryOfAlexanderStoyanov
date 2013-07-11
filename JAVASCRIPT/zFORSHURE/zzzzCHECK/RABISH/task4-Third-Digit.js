// 4. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

var userInput =  1732;
var reversed = userInput.toString().split('').reverse();
var isThirdDigitSeven = (reversed[2] == '7') ? true : false;
console.log(isThirdDigitSeven);