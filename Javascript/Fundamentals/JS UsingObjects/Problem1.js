//Problem 1. Planar coordinates
console.log('\nProblem 1. Planar coordinates');

var P1,
	P2;

P1 = makePoint(1, 2);
P2 = makePoint(3, 4);
P3 = makePoint(1,1.5);
P4 = makePoint(10,21);
P5 = makePoint(5,3);
P6 = makePoint(9,2.5);

L1 = makeLine(P1, P2);
L2 = makeLine(P3, P4);
L3 = makeLine(P5, P6);

console.log('Line 1 start point: '+L1.lineStart);
console.log('Line 1 end point: '+L1.lineEnd);
console.log('Line 1 length: '+L1.lineLength);
console.log('Can L1 L2 and L3 form triangle? '+canFormTriangle(L1,L2,L3));

function makePoint(x, y) {
	return {
		pointX: x,
		pointY: y,
		toString: function(){return 'start: '+this.pointX+'; end: '+this.pointY;}
	};
}

function makeLine(Point1, Point2) {
	return {
		lineStart: Point1,
		lineEnd: Point2,
		lineLength: distance(Point1, Point2)
	};
}

function distance(Point1, Point2) {
	var tmp1,
		tmp2;

	tmp1 = (Point2.pointX - Point1.pointX) * (Point2.pointX - Point1.pointX);
	tmp2 = (Point2.pointY - Point1.pointY) * (Point2.pointY - Point1.pointY);
	return Math.sqrt(tmp1 + tmp2);
}

function canFormTriangle(line1, line2, line3) {
	if (line1+line2>line3 && line2+line3>line1 && line1+line3>line2) {
		return true;
	}else {
		return false;
	}
}


