//Problem 6. Extract text from HTML
console.log('\nProblem 6. Extract text from HTML');

var text = ['<html>',
	'<head>',
	'<title>Sample site</title>',
	'</head>',
	'<body>',
	'<div>text',
	'<div>more text</div>',
	'and more...',
	'</div>',
	'in body',
	'</body>',
	'</html>'
];


console.log(extractText(text));


function extractText(text) {
	var extract = false,
		result = '',
		i,
		len = text.length;



	for (i = 0; i < len; i += 1) {

		for (var j = 0; j < text[i].length; j += 1) {


			if (text[i][j] === '>') {
				extract = true;
				continue;
			}

			if (text[i][j] === '<') {
				extract = false;
				j += 1;
				continue;
			}

			if (extract) {
				result += text[i][j];
			}
		}
	}
	return result;
}