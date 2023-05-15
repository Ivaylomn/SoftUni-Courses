function companyUsers(input) {
    let companyes = {};
    for (const el of input) {
        let [companyName, id] = el.split(' -> ');
        if (!companyes.hasOwnProperty(companyName)) {
            companyes[companyName] = [];
        }
        if (!companyes[companyName].includes(id)) {
            companyes[companyName].push(id);
        }
    }
    Object
        .keys(companyes)
        .sort((a, b) => a.localeCompare(b))
        .forEach(key => console.log(`${key}\n-- ${companyes[key].join('\n-- ')}`))
}

// companyUsers([
//     'SoftUni -> AA12345',
//     'SoftUni -> BB12345',
//     'Microsoft -> CC12345',
//     'HP -> BB12345'
// ]);
companyUsers([
    'SoftUni -> AA12345',
    'SoftUni -> CC12344',
    'Lenovo -> XX23456',
    'SoftUni -> AA12345',
    'Movement -> DD11111'
]);