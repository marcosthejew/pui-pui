USE [puipuiDB]

/*SE INSERTAN INSTRUCTORES */

	INSERT INTO Instructor(cedula, primer_nombre,segundo_nombre,primer_apellido,segundo_apelldo,genero,fecha_nacimiento,fecha_registro,ciudad,direccion,telefono_local,telefono_celular,correo_electronico,nombre_contacto_emergencia,telefono_contacto_emergencia,status)
	VALUES (19765432, 'Juan','Jose','Perez','Gonzales','M', '1989-02-22','2013-05-14','Caracas','Ave principal Los chaguaramos, Res. Yoli' ,'02129443977','04125436788','juanjj@gmail.com','Pedro Rojas','04124567654','Activo');	
	INSERT INTO Instructor(cedula, primer_nombre,segundo_nombre,primer_apellido,segundo_apelldo,genero,fecha_nacimiento,fecha_registro,ciudad,direccion,telefono_local,telefono_celular,correo_electronico,nombre_contacto_emergencia,telefono_contacto_emergencia,status)
	VALUES (15436726, 'Miguel','Angel','Fuenmayor','Cabrera','M', '1985-07-25','2013-05-14','Caracas','Urb Los chorros, Qta. Mary' ,'02123453977','04144328765','migueF@gmail.com','Maria Amelia Cabrera','04128763456','Activo');	
	INSERT INTO Instructor(cedula, primer_nombre,segundo_nombre,primer_apellido,segundo_apelldo,genero,fecha_nacimiento,fecha_registro,ciudad,direccion,telefono_local,telefono_celular,correo_electronico,nombre_contacto_emergencia,telefono_contacto_emergencia,status)
	VALUES (17654379, 'Fabio','Jose','Castillo','Diaz','M', '1990-05-20','2013-05-14','Caracas','La trinidad, urb. socoraima, res. Auyana' ,'02129654378','04163453267','fabfab@gmail.com','Adriana Diaz','04127865434','Activo');	
	
/*INSERTA HORARIO AL INSTRUCTOR 1 */	
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('lunes','8:00:00','12:00:00',1); 
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('martes','8:00:00','12:00:00',1);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('miercoles','8:00:00','12:00:00',1);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('jueves','8:00:00','12:00:00',1);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('viernes','8:00:00','12:00:00',1);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('lunes','14:00:00','18:00:00',1); 
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('martes','14:00:00','18:00:00',1);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('miercoles','14:00:00','18:00:00',1);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('jueves','14:00:00','18:00:00',1);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('viernes','14:00:00','18:00:00',1);
	 
/*INSERTA HORARIO AL INSTRUCTOR 2 */	 
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('lunes','8:00:00','12:00:00',2); 
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('martes','8:00:00','12:00:00',2);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('miercoles','8:00:00','12:00:00',2);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('jueves','8:00:00','12:00:00',2);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('viernes','8:00:00','12:00:00',2);
	 
/*INSERTA HORARIO AL INSTRUCTOR 3 */	
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('lunes','14:00:00','18:00:00',3); 
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('martes','14:00:00','18:00:00',3);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('miercoles','14:00:00','18:00:00',3);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('jueves','14:00:00','18:00:00',3);
	 INSERT
	 INTO Horario_Trabajo(dia,hora_inicio,hora_fin,id_instructor)
	 VALUES ('viernes','14:00:00','18:00:00',3);