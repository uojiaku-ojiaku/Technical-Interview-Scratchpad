// Comment

console.log('Hello World');
// Hello World
// What we have here is a statement. All statements in javascript need to be terminated by a semi colon

2 + 2
// 4

alert('yo')
// pop up alert on browser

// In programming we use a variable to store data temporarily

let name;
console.log(name);
// undefined 

let name = "Mosh";
console.log(name);
// Mosh

// Cannot name a variable a reserved keyword
// Should have a meaningful variable name
// Cannot have a variable name that starts with a number (ex. 1name)
// Cannot have a variable that contains a space or hyphen 
// Variables are case senitive

let firstName
let firstNameBe
let firstNameBeThis
// camelcase notation

// you can declare more than one variable at once:
let firstName, lastName;
// but best practice is to declare each new variable on a single line

let firstName = "Mosh";
let lastName = "Hamedani";

let interestRate = 0.3;
interestRate = 1;
console.log(interestRate);
// 1

const interestRate = 0.3;
interestRate = 1;
console.log(interestRate);
// error
// Assignment to constant variable

// Examples of Primitive/Value Types
let name = "Mosh"; // String literal -- a fancy name for a string
let age = 30; // Number Literal
let isApproved = true; // Boolean Literal
let firstName = undefined;
let lastName = null; //  We use null in times we want to explicitly clear the value of a variable

// we have an operator called typeof, which allows us to check the type of a variable

typeof name;
// "string"

name = 1;
// 1 

typeof name;
// "number"

// When you're dealing with multiple of related variables, you can put those variables in an object

let person = {} // Object Literal
// Inside an object, we add one or more, key value pairs

let person = {
    name: 'Mosh',
    age: 30
}
console.log(person);
// {name: "Mosh", age: 30}