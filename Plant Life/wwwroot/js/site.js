// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar');

    var UserEvents = [];

    $.ajax({
        url: 'Calendars/GetUserEvents'
    }).done(function (e) {
        console.log(e, "e")
        if (e != null && e != undefined) {
            for (i = 0; i < e.length; i++) {
                var newEvent = {
                    id: e[i].eventId,
                    title: e[i].eventName,
                    start: e[i].startDateString
                }
                UserEvents.push(newEvent);
            }
        }
        console.log(UserEvents, "UserEvents");

        var calendar = new FullCalendar.Calendar(calendarEl, {
            plugins: ['dayGrid', 'interaction'],
            events: UserEvents,
            editable: true
        });
        console.log("calendar", calendar);
        calendar.render();
    });
});
