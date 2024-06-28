function roman(s) {
	let table = {
        I: 1,
        V: 5,
        X: 10,
        L: 50,
        C: 100,
        D: 500,
        M: 1000
    }
	let values = s.split('');
	let sum = 0;
	for(let i = 0; i < values.length; i++) {
		if (table[s[i]] < table[s[i+1]]) {
            sum-=table[s[i]]
        } else {
			sum+=table[s[i]]
		}
	}
	return sum;
}

console.log(roman('III'));
console.log(roman('MCMXCIV'));
