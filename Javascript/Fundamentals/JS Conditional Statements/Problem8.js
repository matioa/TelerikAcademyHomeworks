//Problem 8. Number as words
var i,
	wordUnits,
	wordsTens,
	result;

console.log('\nProblem 8 - Number as words');

for (i = 0; i <300; i+=1) {
	if (!i) {
		result = 'zero';
	} else if (i<20) {
		result = units(i);
	} else if (i<100) {
		result = tens((i/10)|0);
		result +=' '+units(i%10);
	} else if (i<1000) {
		result = units((i/100)|0)+' hundred ';
		if ((i-((i/100)|0)*100)>19) {
			result +=tens(((i/10)|0)%10);
			result +=' '+units(i%10);
		} else if (((i-((i/100)|0)*100)>9)) {
			result +=units(i%100);
		} else {
			result +=units(i%10);
		}
	}
	console.log(i+': '+result);
}


function units(input) {
	switch (input) {
		case 1: wordsUnits='one'; break;
		case 2: wordsUnits='two'; break;
		case 3: wordsUnits='three'; break;
		case 4: wordsUnits='four'; break;
		case 5: wordsUnits='five'; break;
		case 6: wordsUnits='six'; break;
		case 7: wordsUnits='seven'; break;
		case 8: wordsUnits='eight'; break;
		case 9: wordsUnits='nine'; break;
		case 10: wordsUnits='ten'; break;
		case 11: wordsUnits='eleven'; break;
		case 12: wordsUnits='twelve'; break;
		case 13: wordsUnits='thirteen'; break;
		case 14: wordsUnits='fourteen'; break;
		case 15: wordsUnits='fifteen'; break;
		case 16: wordsUnits='sixteen'; break;
		case 17: wordsUnits='seventeen'; break;
		case 18: wordsUnits='eighteen'; break;
		case 19: wordsUnits='nineteen'; break;
		default: wordsUnits='';
	}
	return wordsUnits;

}

function tens(input) {
	switch (input) {
		case 2: wordsTens='twenty'; break;
		case 3: wordsTens='thirty'; break;
		case 4: wordsTens='fourty'; break;
		case 5: wordsTens='fifty'; break;
		case 6: wordsTens='sixty'; break;
		case 7: wordsTens='seventy'; break;
		case 8: wordsTens='eighty'; break;
		case 9: wordsTens='ninety'; break;
		default:'';
	}
	return wordsTens;
}