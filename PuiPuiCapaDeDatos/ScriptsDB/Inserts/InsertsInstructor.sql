USE [puipuiDBv1]

/*SE INSERTAN INSTRUCTORES */

	INSERT INTO Instructor(cedula, nombre1,nombre2,apellido1,apellido2,sexo,fecha_nac,fecha_ingreso,entidad_federal,ciudad,direccion,telefono_local,telefono_celular,email,nombre_contacto_emergencia,telefono_contacto_emergencia,inactivo)
	VALUES (19765432, 'Juan','Jose','Perez','Gonzales','M', '1989-02-22','2013-05-14','Dto Capital','Caracas','Ave principal Los chaguaramos, Res. Yoli' ,'02129443977','04125436788','juanjj@gmail.com','Pedro Rojas','04124567654',0);	
	INSERT INTO Instructor(cedula, nombre1,nombre2,apellido1,apellido2,sexo,fecha_nac,fecha_ingreso,entidad_federal,ciudad,direccion,telefono_local,telefono_celular,email,nombre_contacto_emergencia,telefono_contacto_emergencia,inactivo)
	VALUES (15436726, 'Miguel','Angel','Fuenmayor','Cabrera','M', '1985-07-25','2013-05-14','Dto Capital','Caracas','Urb Los chorros, Qta. Mary' ,'02123453977','04144328765','migueF@gmail.com','Maria Amelia Cabrera','04128763456',0);	
	INSERT INTO Instructor(cedula, nombre1,nombre2,apellido1,apellido2,sexo,fecha_nac,fecha_ingreso,entidad_federal,ciudad,direccion,telefono_local,telefono_celular,email,nombre_contacto_emergencia,telefono_contacto_emergencia,inactivo)
	VALUES (17654379, 'Fabio','Jose','Castillo','Diaz','M', '1990-05-20','2013-05-14','Dto Capital','Caracas','La trinidad, urb. socoraima, res. Auyana' ,'02129654378','04163453267','fabfab@gmail.com','Adriana Diaz','04127865434',0);	
	
/*INSERTA HORARIO*/	
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('8:00:00','12:00:00',1,1); 
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('8:00:00','12:00:00',2,1);
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('8:00:00','12:00:00',3,1);
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('8:00:00','12:00:00',4,1);
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('8:00:00','12:00:00',5,1);
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('14:00:00','18:00:00',1,1); 
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('14:00:00','18:00:00',2,1);
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('14:00:00','18:00:00',3,1);
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('14:00:00','18:00:00',4,1);
	 INSERT
	 INTO Horario(hora_inicio,hora_fin,dia_semana,inactivo)
	 VALUES ('14:00:00','18:00:00',5,1);
	 
/*INSERTA HORARIO AL INSTRUCTOR 1 */
	
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(1,1);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(2,1);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(3,1);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(4,1);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(5,1);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(6,1);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(7,1);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(8,1);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(9,1);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(10,1);

/*INSERTA HORARIO AL INSTRUCTOR 2 */	 
	 
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(1,2);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(2,2);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(3,2);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(4,2);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(5,2);
	 
/*INSERTA HORARIO AL INSTRUCTOR 3 */	
	 INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(6,3);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(7,3);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(8,3);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(9,3);
	INSERT INTO Horario_Trabajo (id_horario,id_instructor)
	VALUES(10,3);

