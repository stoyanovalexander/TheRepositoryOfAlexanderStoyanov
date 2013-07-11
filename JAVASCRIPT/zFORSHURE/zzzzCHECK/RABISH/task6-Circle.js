// 6. Write an expression that checks if given print (x,  y) is within a circle K(O, 5).

var userInput =  {x: '-1', y: '2'};
var x = parseInt(userInput.x);
var y = parseInt(userInput.y);
var isItInCircle = ( ( (x > -5) && (x < 5) && (y > -5) && (y < 5) ) || ( ( (x == -5) && (y == 0) ) || ( (x == 5) && (y == 0) ) || ( (x == 0) && (y == -5) ) || ( (x == 0) && (y == 5) ) ) );
console.log(isItInCircle);