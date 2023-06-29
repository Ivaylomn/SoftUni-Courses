async function getInfo() {
    const stopId = document.getElementById('stopId').value;
    const stopName = document.getElementById('stopName');
    const busesList = document.getElementById('buses');
    
    const url = `http://localhost:3030/jsonstore/bus/businfo/${stopId}`;
    try {
        busesList.innerHTML = '';
        
        const res = await fetch(url);
        if (res.status != 200) {
            throw new Error('Error');
        }
        const data = await res.json();
        stopName.textContent = data.name

        for (const [stop, time] of Object.entries(data.buses)) {
            const liElement = document.createElement('li');
            liElement.textContent = `Bus ${stop} arrives in ${time} minutes`;
            busesList.appendChild(liElement);
        }
    } catch (error) {
        stopName.textContent = error.message;
    }
}