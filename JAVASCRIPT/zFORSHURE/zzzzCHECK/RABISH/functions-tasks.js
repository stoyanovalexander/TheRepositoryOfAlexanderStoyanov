// Task 1
// Write a function that returns the last digit of given integer as an English word.
// Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine"
function getLastDigitAsString(n) {
    if (typeof (n) != 'number') {
        throw 'Expecting number value for parameter 1';
    }

    digits = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];

    // Using Math.abs() in order to support negative arguments
    return digits[Math.abs(n % 10)];
}

// Task 2
// Write a function that reverses the digits of given decimal number.
// Example: 256 -> 652
function reveseDigits(n) {
    if (typeof (n) != 'number') {
        throw 'Expecting number value for parameter 1';
    }

    result = 0;
    while (n > 0) {
        result *= 10;
        result += n % 10;
        n = parseInt(n / 10);
    }

    return result;
}

// Task 3
// Write a function that finds all the occurrences of word in a text
//  - The search can case sensitive or case insensitive
//  - Use function overloading
String.prototype.findIndexesOf = function (word, caseSensitive)
{
    if (typeof (word) != 'string') {
        throw 'Expecting string value for parameter 1';
    }

    // Using !! to cast to bool
    caseInsensitive = !(caseSensitive || false);

    text = this.toString();
    if (caseInsensitive) {
        text = this.toLowerCase();
        word = word.toLowerCase();
    }

    occurances = [];

    index = text.indexOf(word);

    while (index > -1) {
        occurances.push(index);
        index = text.indexOf(word, index + 1);
    }

    return occurances;

}

// Task 4
// Write a function to count the number of divs on the web page
Document.prototype.countDivs = function () {
    return this.getElementsByTagName('div').length;
}

// Task 5
// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.
Array.prototype.countOccurances = function (search) {
    count = 0;
    this.forEach(function (item) {
        if (item === search) {
            count++;
        }
    });
    return count;
}

// Task 6
// Write a function that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist)
Array.prototype.isBiggerThanNeighbors = function (index) {
    index = parseInt(index);
    if (index == NaN) {
        throw "Invalid index";
    }
    if (index < 0 || index > this.length - 1) {
        throw "Index out of range";
    }
    if (this.length < 2) {
        return true;
    }
    last = this.length - 1;
    if (index == 0) {
        return this[0] > this[1];
    }
    if (index == last) {
        return this[last] > this[last - 1];
    }
    return this[index] > this[index + 1] && this[index] > this[index - 1];
}

// Task 7
// Write a Function that returns the index of the first element in array that is bigger than its neighbors,
// or -1, if there’s no such element.
// Use the function from the previous exercise.
Array.prototype.indexOfFirstBiggerThanNeighbors = function () {
    for (var i = 0; i < this.length; i++) {
        if (this.isBiggerThanNeighbors(i)) {
            return i;
        }
    }
    return -1;
}
