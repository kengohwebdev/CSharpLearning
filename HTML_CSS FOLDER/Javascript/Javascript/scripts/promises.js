//promises: a callback function to initialize this process that takes in two arguments: resolve and reject
//resolve means it worked
//reject means it failed

//both "return" so the order of resolve and reject matters

//Callback: is essentally a function that is passed as a parameter
/*
function demo1(){
    let p = new Promise(function(resolve, reject){
        let dept={
            id: 1,
            name : "IT"
        }
        reject("service unavailable");
        //resolve(dept);
    })
    
    p.then(function(d){
        console.log(d)
    }).catch(function(e){
        console.log(e)
    })
}
demo1();

let p2= new Promise((resolve, reject) => {
    resolve(2)
})
p2.then(function(d){
    console.log(d)
    return d*2
}).then(function(d1){
    console.log(d1)
    return d1*2
}).then(function(d3){
    console.log(d3)
})
*/

fetch("http://jsonplaceholder.typicode.com/posts").then(function(response){
    return response.json()
}).then(function(data){
    let length = data.length
    console.log(length)
    let tblBody = document.querySelector("#tblPost tbody")
    tblBody.innerHTML="";
    for(let i = 0; i < length; i++){
        let tr = `<tr><td> ${data[i].id} </td> <td> ${data[i].title} </td> <td> ${data[i].body} </td> </tr>`
        tblBody.innerHTML = tblBody.innerHTML + tr;
    }
})



let apiResult = (callback) => {
    return new Promise((resolve, reject) => {
        callback("https://fakerestapi.azurewebsites.net/api/v1/Users").then(function(response){
            console.log(response.json());
            resolve();
        })
    })
};

apiResult(fetch);

let colorChange = (color, time) => {
    return new Promise((resolve, reject) => {
        setTimeout(()=> {
            document.body.style.backgroundColor = color;
            resolve();
        }, time)
    })
}

colorChange("red", 1000)
.then(function(){colorChange("orange", 1000)})
.then(function(){colorChange("yellow", 1000)})
.then(function(){colorChange("green", 1000)})
.then(function(){colorChange("blue", 1000)})


//regex

let string = "FileStr.txt FileNum.txt FileBool.txt music.mp3";
let matchingReg = /\w*.txt/g; 
console.log(typeof(matchingReg));
let boolMatch = matchingReg.exec(string);

while(boolMatch){
    console.log(boolMatch[0]);
    boolMatch = matchingReg.exec(string);
}