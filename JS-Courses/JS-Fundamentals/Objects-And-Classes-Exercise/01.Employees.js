function employes(arr) {
    let allEmployes = {};
    for (const el of arr) {
        allEmployes[el] = el.length;
    }
    
    Object.entries(allEmployes).forEach(element => {
        console.log(`Name: ${element[0]} -- Personal Number: ${element[1]}`);
    })

    // let employes = [];
    // arr.forEach(element => {
    //    let person = {
    //     name: element,
    //     number: element.length
    //    };
    //    employes.push(person);
    // });
    // employes.forEach(element => {
    //     console.log(`Name: ${element.name} -- Personal Number: ${element.number}`);
    // })
}

employes([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
]);