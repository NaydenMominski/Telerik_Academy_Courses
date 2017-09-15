/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function solve() {
    return function sum(args) {

        if (args.length === 0) {
            return null;
        }
        if (args.some(x => isNaN(x))) {
            throw 'Something is wrong!';
        }
        let result = args.reduce((x, y) => (+x) + (+y));
        return result;
    };
}
// console.log(solve()([5, 7, 56]));
module.exports = solve;