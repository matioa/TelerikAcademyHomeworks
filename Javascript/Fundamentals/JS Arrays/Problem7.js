//Problem 7. Binary search
console.log('\nProblem 7. Binary search');

var numbers = [3, 9, 10, 11, 14, 18, 23, 24, 28, 29, 37, 38, 41, 44, 47], 
 	numbersToFind = [2, 3, 10, 27, 29, 47, 55],
 	ind,
 	len; 
 	 
 numbers.map(Number).sort(); 
 	 
 for (ind = 0, len = numbersToFind.length; ind < len; ind+=1) { 
 	console.log(numbersToFind[ind] + '\t[' +  
 		binarySearch(numbers, numbersToFind[ind], 0, numbers.length - 1) + ']'); 
 } 
 
 
 function binarySearch(arr, num, min, max) { 
 	var mid = min + Math.floor((max - min) / 2); 
 	 
     if (max < min || num > arr[max]) { 
         return -1; 
     } 
 
 
     if (arr[mid] > num) { 
         return binarySearch(arr, num, min, mid - 1); 
     } else if (arr[mid] < num) { 
         return binarySearch(arr, num, mid + 1, max); 
     } else { 
         return mid; 
     } 
 } 
