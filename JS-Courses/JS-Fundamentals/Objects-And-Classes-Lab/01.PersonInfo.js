function personInfo(firstName, lastName, age) {
    let myObj = {
        firstName: firstName,
        lastName: lastName,
        age: age
    };
    return myObj;

    //Other way to creat object->
    
    // let secondMyObj = {
    //     firstName,
    //     lastName,
    //     age
    // };

    // And one more way to create object->

    // let thirdMyObj = {};
    // thirdMyObj.firstName = firstName;
    // Or other way to assign value to key->!!!!!!!!!
    // thirdMyObj['firstName'] = firstName
    // thirdMyObj.lastName = lastName;
    // thirdMyObj.age = age;
}

console.log(personInfo("Peter","Pan","20"));