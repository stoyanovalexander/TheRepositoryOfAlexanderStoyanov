﻿// 5. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

var userInput =  8;
var isThirdBitOne = (((userInput >> 3) & 1) == 1) ? true : false;
console.log(isThirdBitOne);