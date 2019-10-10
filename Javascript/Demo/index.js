console.log('Hello World');

function greet() {
    console.log('Hello World');
}

greet();

function greet(name) {
    console.log('Hello' + name)
}

// name is a parameter, only meaningful inside this function
// name is also an input to this function 

greet('John')
// Hello John

// John is an argument to the greet function

// A function can have multiple parameters

function greet(name, lastName) {
    console.log('Hello' + name + ' ' + lastName)
}

greet('John', 'Smith')
// Hello John Smith


function square(number) {
    return number * number;
}

let number = square(2);
console.log(number);
// 4 

console.log(square(2));
// making two function calls

// Functions are sets of statements that either perform a task or calculates and returns a value

