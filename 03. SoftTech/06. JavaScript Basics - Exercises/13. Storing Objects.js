function solve(input) {
    class Student {
        constructor(name, age, grade) {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
    }

    for (let i = 0; i < input.length; i++) {
        let studentData = input[i].split(" -> ");
        let name = studentData[0];
        let age = studentData[1];
        let grade = studentData[2];

        let student = new Student();
        student.name = name;
        student.age = age;
        student.grade = grade;

        console.log(`Name: ${student.name}`);
        console.log(`Age: ${student.age}`);
        console.log(`Grade: ${student.grade}`);
    }
}