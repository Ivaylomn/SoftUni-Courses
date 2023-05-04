function passwordValidator(password) {
    if (isleastTwoDigits(password) === true && isLettersAndDigits(password) === true && isValidLength(password) === true) {
        console.log('Password is valid');
    }
    if(isValidLength(password) === false){
        console.log('Password must be between 6 and 10 characters');
    }
    if(isLettersAndDigits(password) === false){
        console.log('Password must consist only of letters and digits');
    }
    if(isleastTwoDigits(password) === false){
        console.log('Password must have at least 2 digits');
    }

    function isleastTwoDigits(password) {
        if (password.match("[0-9].*[0-9]")){
            return true
        }else {
            return false
        }
    }

    function isLettersAndDigits(password) {
        if (password.match("^[A-Za-z0-9]+$") === null){
            return false;
        }
        return true
    }

    function isValidLength(password) {
        if (password.length < 6 || password.length > 10) {
            return false;
        }
        return true;
    }
}

passwordValidator('logIn');
//passwordValidator('MyPass123'); 
//passwordValidator('Pa$s$s');