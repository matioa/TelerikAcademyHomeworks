//Problem 4. Parse tags
console.log('\nProblem 4. Parse tags');

var textNoNesting,
	textWithNesting,
	formattedText;

textNoNesting = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';
formattedText = parseTags(textNoNesting);
console.log(formattedText);

textWithNesting = 'We are <mixcase>living in a <upcase>yellow submarine</upcase>. We don\'t</mixcase> have <lowcase>anything</lowcase> else.';
formattedText = parseTags(textWithNesting);
console.log(formattedText);


function parseTags(text) {
	var tagUpOpen = '<upcase>',
		tagUpClose = '</upcase>',
		tagLowOpen = '<lowcase>',
		tagLowClose = '</lowcase>',
		tagMixOpen = '<mixcase>',
		tagMixClose = '</mixcase>',
		changeCase = [],
		i,
		len = text.length,
		result = '';

	for (i = 0; i < len; i += 1) {
		if (text.substr(i, tagUpOpen.length) === tagUpOpen) {
			changeCase.unshift(tagUpOpen);
			i += tagUpOpen.length;
		}
		if (text.substr(i, tagLowOpen.length) === tagLowOpen) {
			changeCase.unshift(tagLowOpen);
			i += tagLowOpen.length;
		}
		if (text.substr(i, tagMixOpen.length) === tagMixOpen) {
			changeCase.unshift(tagMixOpen);
			i += tagMixOpen.length;
		}

		if (text.substr(i, tagUpClose.length) === tagUpClose) {
			changeCase.shift();
			i += tagUpClose.length;
		}
		if (text.substr(i, tagLowClose.length) === tagLowClose) {
			changeCase.shift();
			i += tagLowClose.length;
		}
		if (text.substr(i, tagMixClose.length) === tagMixClose) {
			changeCase.shift();
			i += tagMixClose.length;
		}

		if (changeCase.length) {
			switch (changeCase[0]) {
				case tagUpOpen:
					result += text[i].toUpperCase();
					break;
				case tagLowOpen:
					result += text[i].toLowerCase();
					break;
				case tagMixOpen:
					if (Math.random() < 0.5) {
						result += text[i].toLowerCase();
					} else {
						result += text[i].toUpperCase();
					}
					break;
				default:
					break;
			}
			continue;
		}
		result += text[i];
	}
	return result;
}