//Problem 9. Extract e-mails
console.log('\nProblem 9. Extract e-mails');

var text = 'Some text with dii_di@gmail.com is another text, kkk.kii@garg.co.uk, some other emails @dkkd.com';
var emailTemplate = new RegExp(/\b[A-z0-9._%+-]+@[A-z0-9.-]+\.[A-z]{2,4}\b/g); ;

console.log(findAllEmails(text,emailTemplate));


function findAllEmails(text, template) {
	var emails=[];

	emails = text.match(template);
	return emails;
}