const display = document.querySelector(".dispaly");
const button = document.querySelector("button");
const specialChars = ["%", "*", "/", "-", "+", "="];
let output = "";

const calculate = (btnvalue) => {
    display.focus();
    if (btnvalue == "=" && output != "") {
        output = eval(output.replace("%", "/100"));
    }
    else if (btnvalue == "AC") {
        output = "";
    }
    else if (btnvalue == "DEL") {
        output = output.toString().slice(0, -1);
    }
    else {
        if (output == "" && specialChars.includes(btnvalue)) return;
        output += btnvalue;
    }
    display.value = output;
}
button.forEach((button) => {
    button.addEventListerner("click", (e) => calculate(e.target.dataset.value));
});