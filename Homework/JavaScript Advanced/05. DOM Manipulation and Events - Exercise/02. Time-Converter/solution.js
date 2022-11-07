function attachEventsListeners() {

    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');

    let rations = {
        days:1, 
        hours:24, 
        minutes:1440, 
        seconds:86400
    };

    let dayButton = document.getElementById('daysBtn').addEventListener('click', onConvert); 
    let hourButton = document.getElementById('hoursBtn').addEventListener('click', onConvert); 
    let minutesButton = document.getElementById('minutesBtn').addEventListener('click', onConvert); 
    let secondsButton = document.getElementById('secondsBtn').addEventListener('click', onConvert); 


    function onConvert(event) {
     let input = event.target.parentElement.querySelector('input[type="text"]');

     let time = convert(Number(input.value), input.id)
     days.value = time.days;
     hours.value = time.hours; 
     minutes.value = time.minutes; 
     seconds.value = time.seconds;

    }

    function convert(value, id) {
     let day = value / rations[id]; 
     
     return {
        days:day,
        hours: day*rations.hours,
        minutes: day*rations.minutes, 
        seconds: day*rations.seconds
     }

    }

    
}