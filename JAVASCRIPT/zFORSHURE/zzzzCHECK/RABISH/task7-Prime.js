// 7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

function isPrime(n) {
	var square = parseInt(Math.sqrt(n));
	var isItPrime = true;
	if (square > 1) {
		for(var i=2; i <= square; i++) {
			if (n % i == 0) {
				isItPrime = false;
				return false;
			}
		}
	}
	return isItPrime;
}

for (g = 2; g <= 100; g++) {
	console.log('checking: ' + g + ' -> ' + isPrime(g));
	//if (isPrime(g)) {console.log(g);}
}