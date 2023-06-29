function attachEvents() {

    const location = document.getElementById('location');
    const forecastElement = document.getElementById('forecast');
    const currentWeatherDivElement = document.getElementById('current');
    const upcomingWeatherDivElement = document.getElementById('upcoming');

    document.getElementById('submit').addEventListener('click', getLocation);

    const baseUrl = `http://localhost:3030/jsonstore/forecaster/`;
    async function getLocation() {

        try {
            forecastElement.style.display = 'block';
            currentWeatherDivElement.style.display = 'block';

            const res = await fetch(`${baseUrl}locations`);
            const data = await res.json();

            const locationCode = data.find(x => x.name == location.value);

            const resTwo = await fetch(`${baseUrl}today/${locationCode.code}`);
            const todayWheatherData = await resTwo.json();

            const resThree = await fetch(`${baseUrl}upcoming/${locationCode.code}`);
            const upcomingWheatherData = await resThree.json();

            const [city, county] = todayWheatherData.name.split(', ');
            let conditionSymbol = getConditionSymbol(todayWheatherData.forecast.condition)
            const degreeSymol = '&#176';

            const forecastDivElement = document.createElement('div');
            forecastDivElement.classList.add('forecasts');

            const conditionSymbolSpanElement = document.createElement('span');
            conditionSymbolSpanElement.classList.add('condition');
            conditionSymbolSpanElement.classList.add('symbol');
            conditionSymbolSpanElement.innerHTML = conditionSymbol;
            forecastDivElement.appendChild(conditionSymbolSpanElement);

            const conditionSpanElement = document.createElement('span');
            conditionSpanElement.classList.add('condition');

            const locationSpanElement = document.createElement('span');
            locationSpanElement.classList.add('forecast-data');
            locationSpanElement.textContent = `${city}, ${county}`;

            const degreeSpanElement = document.createElement('span');
            degreeSpanElement.classList.add('forecast-data');
            degreeSpanElement.innerHTML = `${todayWheatherData.forecast.low}${degreeSymol}/${todayWheatherData.forecast.high}${degreeSymol}`;

            const weatherSpanElement = document.createElement('span');
            weatherSpanElement.classList.add('forecast-data');
            weatherSpanElement.textContent = `${todayWheatherData.forecast.condition}`

            conditionSpanElement.appendChild(locationSpanElement);
            conditionSpanElement.appendChild(degreeSpanElement);
            conditionSpanElement.appendChild(weatherSpanElement);

            forecastDivElement.appendChild(conditionSpanElement);
            currentWeatherDivElement.appendChild(forecastDivElement);

            const upcomingWheatherDivElement = document.createElement('div');
            upcomingWheatherDivElement.classList.add('forecast-info');

            upcomingWheatherData.forecast.forEach(x => {
                conditionSymbol = getConditionSymbol(x.condition);

                const upcomingWheatherSpanElement = document.createElement('span');
                upcomingWheatherSpanElement.classList.add('upcoming');

                const upcomingWheatherSymbolSpanElement = document.createElement('span');
                upcomingWheatherSymbolSpanElement.classList.add('symbol');
                upcomingWheatherSymbolSpanElement.innerHTML = conditionSymbol;

                const upcomingWheatherDataElement = document.createElement('span');
                upcomingWheatherDataElement.classList.add('forecast-data');
                upcomingWheatherDataElement.innerHTML = `${x.low}${degreeSymol}/${x.high}${degreeSymol}`;

                const upcomingWheatherInfoSpanElement = document.createElement('span');
                upcomingWheatherInfoSpanElement.classList.add('forecast-data');
                upcomingWheatherInfoSpanElement.textContent = x.condition;

                upcomingWheatherDivElement.appendChild(upcomingWheatherSpanElement);
                upcomingWheatherSpanElement.appendChild(upcomingWheatherSymbolSpanElement);
                upcomingWheatherSpanElement.appendChild(upcomingWheatherDataElement);
                upcomingWheatherSpanElement.appendChild(upcomingWheatherInfoSpanElement);
            })

            upcomingWeatherDivElement.appendChild(upcomingWheatherDivElement);

        } catch (error) {
            
            const paragraphElement = document.createElement('p');
            Array.from(forecastElement.children).forEach(x => {
                x.style.display = 'none';
            })
            paragraphElement.classList.add('label');
            paragraphElement.textContent = 'Error';
            forecastElement.appendChild(paragraphElement);
        }
    }

    function getConditionSymbol(condition) {
        switch (condition) {
            case 'Sunny':
                return '&#x2600';
            case 'Partly sunny':
                return '&#x26C5';
            case 'Overcast':
                return '&#x2601';
            case 'Rain':
                return '&#x2614';
        }
    }
}

attachEvents();