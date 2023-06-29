function solve() {
    const infoBox = document.querySelector('#info span');
    const departButton = document.getElementById('depart');
    const arriveButton = document.getElementById('arrive');

    let initialStop = 'depot';
    let currentBusStop = '';
    const baseUrl = `http://localhost:3030/jsonstore/bus/schedule/`;
    async function depart() {
        try {
            const res = await fetch(`${baseUrl}${initialStop}`);
            const data = await res.json();

            infoBox.textContent = `Next stop ${data.name}`;
            currentBusStop = data.name;
            initialStop = data.next;

            departButton.disabled = true;
            arriveButton.disabled = false;
        } catch (error) {
            departButton.disabled = true;
            arriveButton.disabled = true;
            infoBox.textContent = 'Error';
        }
    }

    function arrive() {
        arriveButton.disabled = true;
        departButton.disabled = false;

        infoBox.textContent = `Arriving ${currentBusStop}`;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();