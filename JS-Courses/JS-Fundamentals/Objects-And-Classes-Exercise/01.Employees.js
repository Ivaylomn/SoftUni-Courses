function employes(arr) {
    //let allEmployes = [];
    for (const el of arr) {
        let obj = {
            employeeName: el,
            personalNum: el.length
        };
        //allEmployes.push(obj);
        console.log(`Name: ${obj['employeeName']} -- Personal Number: ${obj.personalNum}`);
    }

    /*for (const el of allEmployes) {
        for (const [key, value] of Object.entries(el)) {
            console.log(`Name: ${el[key]} -- Personal Number: ${el.personalNum}`);
            break;
        }
    }
    */
}

employes([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
]);