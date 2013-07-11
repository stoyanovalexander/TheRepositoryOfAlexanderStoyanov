// 2. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var userInput = 35;
var canBeDivided;
canBeDivided = (((userInput % 7) == 0) && ((userInput % 5) == 0)) ? true : false;
console.log(canBeDivided);