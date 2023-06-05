function validate() {
    const inputEmail = document.getElementById('email');
    const pattern = /^[a-z]+@[a-z]+\.[a-z]+$/;
    inputEmail.addEventListener('change', error);

    function error(e) {
        console.log(e);
        if (!pattern.test(e.target.value)) {
            e.target.classList.add('error');
        }else {
            e.target.classList.remove('error');
        }
    }
}