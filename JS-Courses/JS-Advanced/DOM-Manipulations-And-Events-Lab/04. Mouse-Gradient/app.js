function attachGradientEvents() {
    const divElement = document.getElementById('gradient');
    divElement.addEventListener('mousemove', moved);
    divElement.addEventListener('mouseout', gradientOut);

    function gradientOut(){
        document.getElementById('result').textContent = '';
    }

    function moved(e){
        let result = Math.trunc(e.offsetX / (e.target.clientWidth - 1) * 100);
        document.getElementById('result').textContent = result + '%';
    }
}