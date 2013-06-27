use puipuiDBv1;

insert into Musculo (nombre,descripcion,inactivo) values (' Abdominal',null,0);
insert into Musculo (nombre,descripcion,inactivo) values ('Bicep',null,0);
insert into Musculo (nombre,descripcion,inactivo) values ('Tricep',null,0);
insert into Musculo (nombre,descripcion,inactivo) values ('Pectoral',null,0);
insert into Musculo (nombre,descripcion,inactivo) values ('Detloides',null,0);

ALTER TABLE Ejercicio ALTER COLUMN descripcion nchar(200);

insert into Ejercicio (nombre, descripcion, inactivo) values ('abdominales',		      'acostarse en el piso con el cuello recto y las manos atras de la cabeza',	0);
insert into Ejercicio (nombre, descripcion, inactivo) values ('bicicleta',				  'acostarse en el piso con las manos en el cuello subir la rodilla 45 grados',	0);
insert into Ejercicio (nombre, descripcion, inactivo) values ('abdominales oblicuos',	  'acostarse en el piso con las manos en la cabeza cruzar las piernas',			0);
insert into Ejercicio (nombre, descripcion, inactivo) values ('martillo',				  'pararse y con una mancuerna elevarla al hombro',								0);
insert into Ejercicio (nombre, descripcion, inactivo) values ('curl de bicep',			  'con los codos pegados al tronco flexionar los brazos',						0);
insert into Ejercicio (nombre, descripcion, inactivo) values ('curl de bicep concentrado','sentarse y con una mancuerna flexionar hasta el hombro',						0);
insert into Ejercicio (nombre, descripcion, inactivo) values ('copa',					  'con una mancuerna y los brazos detras de la cabeza subir y bajarla',			0);
insert into Ejercicio (nombre, descripcion, inactivo) values ('press de banca',			  'acostado se sostiene una barra con sobre el pecho',							0);
insert into Ejercicio (nombre, descripcion, inactivo) values ('crossface',				  'acostado sostener una mancuerna con un brazo y flexionarlo en T',			0);

insert into Musculo_Involucrado (id_ejercicio,id_musculo,inactivo) values(1,1,0);
insert into Musculo_Involucrado (id_ejercicio,id_musculo,inactivo) values(2,1,0);
insert into Musculo_Involucrado (id_ejercicio,id_musculo,inactivo) values(3,1,0);
insert into Musculo_Involucrado (id_ejercicio,id_musculo,inactivo) values(4,2,0);
insert into Musculo_Involucrado (id_ejercicio,id_musculo,inactivo) values(5,2,0);
insert into Musculo_Involucrado (id_ejercicio,id_musculo,inactivo) values(6,2,0);
insert into Musculo_Involucrado (id_ejercicio,id_musculo,inactivo) values(7,3,0);
insert into Musculo_Involucrado (id_ejercicio,id_musculo,inactivo) values(8,3,0);
insert into Musculo_Involucrado (id_ejercicio,id_musculo,inactivo) values(9,3,0);
