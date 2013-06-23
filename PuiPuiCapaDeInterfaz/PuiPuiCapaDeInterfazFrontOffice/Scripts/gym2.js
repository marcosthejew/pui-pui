$(document).ready(function () {


    var date = new Date();
    var d = date.getDate();
    var m = date.getMonth();
    var y = date.getYear();

    $('#calendar').fullCalendar({
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
        },
        buttonText: {
            today: 'Hoy',
            month: 'Mes',
            day: 'Día',
            week: 'Semana'
        },
        editable: true,
        height: 350,
        monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
        dayNames: ['Domingo', 'Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sábado'],
        dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mie', 'Jue', 'Vie', 'Sab'],
        weekends: true,
        dayClick: function(date, allDay, jsEvent, view) {
            if (allDay) {       
                alert('Clicked on the entire day: ' + date);
            }else{
                alert('Clicked on the slot: ' + date);
            }
        },
        eventClick: function (calEvent, jsEvent, view) {
            alert(calEvent.id);
       },
        //events: "obtenerEventos_sinNodoEvents.ashx?id=28"
        //events: "/Sample.ashx"
        eventSources: [
        // your JSON event source
        {
            url: '/Presentacion/Vista/Modulo3/ReservarClase/Reservas.ashx',// use the `url` property
            color: 'yellow',    // an option!
            textColor: 'black'  // an option!
        }
        ]
          
        });

});

