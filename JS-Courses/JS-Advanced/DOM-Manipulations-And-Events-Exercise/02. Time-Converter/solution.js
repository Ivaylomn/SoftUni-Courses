function attachEventsListeners() {
    let inputDaysElement = document.getElementById('days');
    let inputHoursElement = document.getElementById('hours');
    let inputMinutesElement = document.getElementById('minutes');
    let inputSecondsElement = document.getElementById('seconds');

    document.getElementById('daysBtn').addEventListener('click', () => {
        inputHoursElement.value = inputDaysElement.value * 24;
        inputMinutesElement.value = inputHoursElement.value * 60;
        inputSecondsElement.value = inputMinutesElement.value * 60;
    });

    document.getElementById('hoursBtn').addEventListener('click', () => {
        inputDaysElement.value = inputHoursElement.value / 24;
        inputMinutesElement.value = inputHoursElement.value * 60;
        inputSecondsElement.value = inputMinutesElement.value * 60;
    });

    document.getElementById('minutesBtn').addEventListener('click', () => {
        inputDaysElement.value = inputMinutesElement.value / 60 / 24;
        inputHoursElement.value = inputMinutesElement.value / 60;
        inputSecondsElement.value = inputMinutesElement.value * 60;
    });

    document.getElementById('secondsBtn').addEventListener('click', () => {
        inputDaysElement.value = inputSecondsElement.value / 60 / 60 / 24;
        inputHoursElement.value = inputSecondsElement.value  / 60 / 60;
        inputMinutesElement.value = inputSecondsElement.value  / 60;
    });
}