/// <reference path="../Vistas/VReservarClase/ConsultarDetalleReservacionClase.aspx" />
/// <reference path="../Vistas/VReservarClase/ReservarClase.aspx" />
/// <reference path="../Vistas/VReservarClase/ReservarClase.aspx" />
/// <reference path="../Vistas/VReservarClase/ReservarClase.aspx" />
/// <reference path="../Vistas/VReservarClase/ReservarClase.aspx" />
/// <reference path="../Vistas/VReservarClase/ReservarClase.aspx" />
/// <reference path="../Vistas/VReservarClase/ReservarClase.aspx" />
$(document).ready(function () {
    var date = new Date();
    var d = date.getDate();
    var m = date.getMonth();
    var y = date.getYear();
    $('#calendar2').fullCalendar({
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
        timeFormat: 'HH:mm{ - HH:mm}',
        editable: false,
        height: 700,
        monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
        dayNames: ['Domingo', 'Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sábado'],
        dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mie', 'Jue', 'Vie', 'Sab'],
        weekends: true,
        dayClick: function (date, allDay, jsEvent, view) {
            if (allDay) {
                alert('Debe hacer click sobre algun evento registrado');
            } else {
                alert('Debe hacer click sobre algun evento registrado');
            }
        },
        eventSources: [
       { 
           url: '/Vistas/VReservarClase/Reservas.ashx',// use the `url` property
           color: '#CCFF33',    // an option!
           textColor: 'black'  // an option!
       }
        ],
        eventClick: function (calEvent, jsEvent, view) {
            //alert('el id del evento es ' + calEvent.id);
            //window.location.href ="/Vistas/VReservarClase/ConsultarDetalleReservacionClase.aspx?idEvento=" + calEvent.id;
            $("#myDiv").load("/Vistas/VReservarClase/ConsultarDetalleReservacionClase.aspx?idEvento=" + calEvent.id).dialog({ title: calEvent.title });
            $("#myDiv").dialog("open");
            return false;
        },
        eventRender: function (event, element) {
            element.qtip({
                content: {
                    title: { text: event.title },
                    text: '<span class="title" style="font-weight:bold;">Inicio: </span>' + ($.fullCalendar.formatDate(event.start, 'hh:mmtt')) +
                        '<br><span class="title" style="font-weight:bold;">Finaliza: </span>' + ($.fullCalendar.formatDate(event.end, 'hh:mmtt')) +
                        '<br><span class="title" style="font-weight:bold;">Instructor: </span>' + event.instructor +
                        '<br><span class="title" style="font-weight:bold;">ID: </span>' + event.id +
                        '<br><span class="title" style="font-weight:bold;">Click para mas Info</span>'
                      },
                position: {
                    adjust: { screen: true },
                    corner: { target: 'bottomMiddle', tooltip: 'topLeft' }
                },
                show: {
                    solo: true, effect: { type: 'slide' }, effect: function () {
                        $(this).fadeTo(200, 0.8);
                    }
                },
                hide: { when: 'mouseout', fixed: true },
                style: {
                    tip: true, // Give it a speech bubble tip
                    border: {
                        width: 2,
                        radius: 5,
                        color: '#FFFF33'

                    },
                    title: {
                        color: 'black',
                        background: '#CCFF33'
                    },
                }
            });
        }       
    });
    $('.fc-event').qtip({
        content: 'Content',
        show: { when: { event: 'mouseover' } },
        hide: { when: { event: 'unfocus' } },
        style: {
            name: 'blue',
            border: {
                width: 2,
                radius: 2,
                color: '#6699CC'
            },
            width: 300
        }
    });
    $("#myDiv").dialog({
        autoOpen: false,
        maxWidth: 550,
        maxHeight: 450,
        width: 550,
        height: 450,
        modal: true,
        resizable: false
       });
});

