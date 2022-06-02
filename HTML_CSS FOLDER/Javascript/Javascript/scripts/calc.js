
function addition(){
    let num1 = parseFloat(document.querySelector("#txtFirstNumber").value);
    let num2 = parseFloat(document.querySelector("#txtSecondNumber").value);
    let sum = num1 + num2;
    document.querySelector("#txtResult").value = sum;
}

let subtractButton = document.querySelector("#btnSubtract");
subtractButton.addEventListener("click", function(){
    let num1 = parseFloat(document.querySelector("#txtFirstNumber").value);
    let num2 = parseFloat(document.querySelector("#txtSecondNumber").value);
    let diff = num1 - num2;
    document.querySelector("#txtResult").value = diff;
})

function toggle(element){
    let pbody = element.nextElementSibling;
    if(pbody.classList.contains("hide")){
        pbody.classList.remove("hide");
        pbody.classList.add("show");
    }else{
        pbody.classList.remove("show");
        pbody.classList.add("hide");
    }
}