USE [puipuiDB]
---Datos de Clase Salon
INSERT INTO Clase_Salon(isReservado,id_clase,id_salon,id_instructor)
VALUES (1,(select id_clase from Clase where nombre='Spinning'),1,(select id_instructor from Instructor where primer_apellido='Perez'))

INSERT INTO Clase_Salon(isReservado,id_clase,id_salon,id_instructor)
VALUES (1,(select id_clase from Clase where nombre='Pilates'),2,(select id_instructor from Instructor where primer_apellido='Castillo'))

INSERT INTO Clase_Salon(isReservado,id_clase,id_salon,id_instructor)
VALUES (1,(select id_clase from Clase where nombre='Abdominales'),3,(select id_instructor from Instructor where primer_apellido='Fuenmayor'))

---Datos de horario reserva
INSERT INTO Horario_Reserva(fecha_inicio,fecha_fin,id_clase_salon)
VALUES ('2013-05-29 10:30:00','2013-05-29 11:30:00',1)
			
INSERT INTO Horario_Reserva(fecha_inicio,fecha_fin,id_clase_salon)
VALUES ('2013-06-09 08:30:00','2013-06-09 10:30:00',2)	

INSERT INTO Horario_Reserva(fecha_inicio,fecha_fin,id_clase_salon)
VALUES ('2013-05-27 08:30:00','2013-05-27 10:30:00',3)				

---instructores disponibles.
