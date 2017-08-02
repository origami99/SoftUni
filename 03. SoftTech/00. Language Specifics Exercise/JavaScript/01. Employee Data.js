function solve(input) {
    let empData = ["Amanda", "Jonson", "27", "f", "8306112507", "27563571"];
    let empText = ["First name: ", "Last name: ", "Age: ", "Gender: ", "Personal ID: ", "Unique Employee number: "];

    for (let i = 0; i < empData.length; i++) {
        console.log(empText[i] + empData[i]);
    }
}
