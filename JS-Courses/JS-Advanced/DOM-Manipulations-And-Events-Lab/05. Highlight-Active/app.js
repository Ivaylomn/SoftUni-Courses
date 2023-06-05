function focused() {
    const divElements = Array.from(document.getElementsByTagName('input'));
    console.log(divElements);
    for (const el of divElements) {
        el.addEventListener('focus', focused);
        el.addEventListener('blur', blured);
    }
    function focused(e) {
        e.target.parentNode.classList.add('focused')
    }
    function blured(e){
        e.target.parentNode.classList.remove('focused');
    }
}