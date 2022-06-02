//alert("Hello World");

// javascript is a weakly typed language
/*
let variable = 0;
console.log(variable);
variable = true;
console.log(variable);
variable = "I am a string now";
console.log(variable);

//Typescript: a (more) strongly typed languague as a super set of javascript
//console.log(letv);
console.log(varv);
let letv = 1;
var varv = 2;
varv = true;
const constv = 3;
console.log(letv);
console.log(varv);
*/
// constv = 5; const cannot change value

/*
Number
String
Boolean
null
undefined
NaN //it is a number type but different because it stands for "not a number"
Symbol
*/
/*
let nullVar = null;
let nullUndef = undefined;
console.log(typeof(nullUndef));
console.log(nullVar);
*/
/*
let numval = 1;
let stringval = "1";
console.log(numval == stringval); //checks for "value"
console.log(numval === stringval); //checks for identity and data type

let Naaaaa = 0/"i";
console.log(Naaaaa);
*/
/*
console.log(100 + "200"); //100200
console.log(100 - "200"); // -100
console.log(100 + true);  // 101
*/
/* Falsy and Truthy values 
false: 0, "", null, undefined, NaN
true: "anything else"
if("any string"){
}else{
}*/

//console.WriteLine($"{item}")
//string interpolation
/*
console.log(`${letv}`);

if(true){}
else{};

switch(letv){
    case 1:
        console.log("rigth on");
    default:
        console.log("default case");
}

for(let i =0; i< 10; i++){
    console.log(i);
}
*/

/*
let arr1 = ["zero", 1, 2, 3];
let arr2 = ["zero", 1, 2, 3];
//arr2 = arr1;
//console.log(arr1 == arr2);

let arrEx = [1, 2, true, [true, null, false], "string", "another one"];
console.log(arrEx[1000]);
console.log(arrEx.length);

arrEx[100] = "hi i obviously dont belong here";
console.log(arrEx.length);
console.log(arrEx);
console.log(arrEx[6]);
*/
/*
.pop // remove from end
.push //add at end
.shift //removes first
.unshift //add to the beginning */
/*
let student = {
    name: "brad",
    grades: [
        firstYear = 85,
        secondYear = 95
    ],
    year: 1000,
    perfAttend: false
}

student.year;
for(let item in student){
    console.log(item);
}
*/
/*
function shout(){
    console.log("HI THERE TIM");
}
shout();
function sum(a, b){
    console.log(a + b);
    return a + b;
}
sum("this", " that");

let dele = shout();
console.log(typeof(dele));
*/

let a = 10; //global scope in relation to the function
/*
function outer(){
    let a = 20; //Functional scoping
    console.log(`${a} this is a inside funct`);
    a = "bird"; //functional scoping will not change outside value
    let b = 20;
    console.log(`${a} this is a inside funct`);
    console.log(`${b} this is b inside funct`);
}
console.log(`${a} this is a before outer out funct`);
outer();
console.log(`${a} this is a out funct`);*/
//console.log(`${b} this is b out funct`); //crashes, example of functional scoping


// Functional scoping: if variables are defined in the function, they are not really available outside the function. 
//if you declare a variable with the same name and keep it function scoped, it prevents changing the data outside the function

//block scoping: let lets you use scope that keeps data from leaking out
// however, var is not that great because it does not allow for block scoping
// because it is a global from instantiation and created outside scope.

//console.log(w);
/*
if(true){
    let z= 0;
    const y = 1;
    var w = "win";
}*/
//console.log(w);
//console.log(y);
//console.log(z);

//var and let hoisting

// lexical scoping: when you nest functions, only the inner functions have access to the values
// outside, when the variables are instantiated, the outer function cannot acces it, but the inner function can
/*
function outer(){
    let b = 20; 
    function inner(){
        let c = 10;
        console.log(b);
    }
    inner();
    console.log(c);
}
outer();
*/
//closures: nested functions that access data outside their own scope.

//Shorthand arrow functions
let arrow = x => {
    return x * 10;
}

console.log(arrow(10));


let student = {
    name: "brad",
    grades: [
        firstYear = 85,
        secondYear = 95
    ],
    year: 1000,
    perfAttend: false,
    grader :function(){
        return this.grades;
    }
}

