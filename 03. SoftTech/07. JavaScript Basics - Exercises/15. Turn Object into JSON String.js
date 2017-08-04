function solve(input) {
    class Obj {
        constructor(name, surname, age, grade, date, town) {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.grade = grade;
            this.date = date;
            this.town = town;
        }
    }

    let obj = new Obj();

    for (let line of input) {
        let key = line.split(" -> ")[0];
        let val = line.split(" -> ")[1];

        if (val == Number(val)) {
            val = Number(val);
        }

        obj[key] = val;
    }

    console.log(JSON.stringify(obj));
}