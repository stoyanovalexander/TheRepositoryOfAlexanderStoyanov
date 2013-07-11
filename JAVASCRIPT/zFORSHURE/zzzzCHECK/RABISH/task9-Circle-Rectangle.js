// 9. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

var userInput =  {x: '-1', y: '2'};
var x = parseInt(userInput.x);
var y = parseInt(userInput.y);
var isItInCircle = ( ( (x > -2) && (x < 4) && (y > -2) && (y < 4) ) || ( ( (x == -2) && (y == 1) ) || ( (x == 4) && (y == 1) ) || ( (x == 1) && (y == -2) ) || ( (x == 1) && (y == 4) ) ) );
var isItInRectangle = !( (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1) );
var isItBoth = isItInCircle && isItInRectangle;
console.log(isItBoth);