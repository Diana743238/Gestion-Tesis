--------------------------------------------------------------------------
---- CREACION DE LA BASE DE DATOS
--------------------------------------------------------------------------
use master
go
if exists (select * from sysdatabases where name = 'BdGestionTesis')
drop database BdGestionTesis
go
create database BdGestionTesis
go
--------------------------------------------------------------------------
-- CREACION DE LA TABLA TESISTA
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para tesista
create table TTesista
( -- lista de atributos
CodTesista varchar(6),
Nombre varchar(50) not null,
ApellidoPaterno varchar (50) not null,
ApellidoMaterno varchar (50) not null,
DNI varchar(8),
CarreraProfesional varchar (50) not null,
FechaNacimiento date,
-- definicion de la clave foranea
primary key (CodTesista)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA DOCENTES
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para docente
create table TDocentes
( -- lista de atributos
CodDocente varchar(10) not null,
Nombre varchar(50) not null,
ApellidoPaterno varchar (50) not null,
ApellidoMaterno varchar (50) not null,
DNI varchar (8) ,
Gmail varchar (20),
Telefono varchar (9),
Categoria varchar (20),
DepAcademico varchar (50),
Disponibilidad varchar (20),
-- definicion de la clave foranea
primary key (CodDocente)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA TESIS
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para tesis
create table TTesis
( -- lista de atributos
CodTesis varchar(10)not null,
Titulo varchar(50) not null,
 
-- definicion de la clave foranea
primary key (CodTesis),
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA PLAN DE TESIS
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para plan tesis
create table TPlanTesis
( -- lista de atributos
CodPlanTesis varchar(10),
TituloPlanTesis varchar(50) not null,
Asesor1 varchar(10) ,
Asesor2 varchar(10) ,
Autor1 varchar (6) ,
Autor2 varchar (6) ,
Autor3 varchar (6) ,
-- definicion de la clave foranea
primary key (CodPlanTesis),
foreign key (Asesor1) references TDocentes(CodDocente),
foreign key (Asesor2) references TDocentes(CodDocente),
foreign key (Autor1) references TTesista(CodTesista),
foreign key (Autor2) references TTesista(CodTesista),
foreign key (Autor3) references TTesista(CodTesista),
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA RESOLUCION
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para resolucion
create table TResolucion
( -- lista de atributos
nroResolucion int not null,
asunto varchar (50) not null, --asunto: AsignacionDictaminante,ActaSustentación,AsignacionJurado
implicado1 varchar (10),
implicado2 varchar (10),
implicado3 varchar (10),
implicado4 varchar (10),
implicado5 varchar (10),
-- definicion de la clave foranea
primary key (nroResolucion),
foreign key (implicado1) references TDocentes(CodDocente),
foreign key (implicado2) references TDocentes(CodDocente),
foreign key (implicado3) references TDocentes(CodDocente),
foreign key (implicado4) references TDocentes(CodDocente),
foreign key (implicado5) references TDocentes(CodDocente),
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA MEMORANDO (DESIGNACION DE LOS EVALUADORES)
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para memorando
create table TMemorando
( -- lista de atributos
nroMemorando int not null,
Evaluador1 varchar (10) not null,
Evaluador2 varchar (10) not null,
-- definicion de la clave foranea
primary key (nroMemorando),
foreign key (Evaluador1) references TDocentes(CodDocente),
foreign key (Evaluador2) references TDocentes(CodDocente)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA LIBRO DE INSCRIPCION DE TESIS
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para resolucion
create table TLibroInscripcion
( -- lista de atributos
nroLibroInscripcion int,
FechaInscripcion date,
CodTesisInscrita varchar (10) not null,
-- definicion de la clave foranea
primary key (nroLibroInscripcion),
foreign key (CodTesisInscrita) references TTesis(CodTesis),
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA SOLICITUD (TRAMITE)
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para resolucion
create table TSolicitud
( -- lista de atributos
nroSolicitud varchar (10) not null,
fechaSolicitud date not null,
tipo varchar (30) not null, --tipo: evaluacionTesis, evaluacionPlanTesis, Sustentacion
solicitante varchar (6) not null,
-- definicion de la clave foranea
primary key (nroSolicitud),
foreign key (solicitante) references TTesista(CodTesista)
)
Go
--------------------------------------------------------------------------
-- CREACION DE LA TABLA TRAMITES
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para  
create table TTramites
( -- lista de atributos
CodTramites varchar (10) not null,
Descripcion varchar (60),
-- definicion de la clave foranea
primary key (CodTramites)
)
Go
--------------------------------------------------------------------------
-- CREACION DE LA TABLA INFORME
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para informe
create table TInforme
( -- lista de atributos
nroInforme varchar (10) not null,
FechaEmision date,
observaciones varchar (50),
Evaluador varchar (10),
tipo varchar (50), --tipos: EvaluacionPlanTesis, EvaluacionTesis
-- definicion de la clave foranea
primary key (nroInforme),
foreign key (Evaluador) references TDocentes(CodDocente)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA PROVEIDO
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para proveido
create table TProveido
( -- lista de atributos
codProveido varchar (10) not null,
Tipo varchar (20) not null,
FechaEmision date,--tipos: EvaluacionPlanTesis, EvaluacionTesis
Nominado1 varchar (10),
Nominado2 varchar (10),
Nominado3 varchar (10),
Nominado4 varchar (10),
Nominado5 varchar (10),
-- definicion de la clave foranea
primary key (codProveido),
foreign key (Nominado1) references TDocentes(CodDocente),
foreign key (Nominado2) references TDocentes(CodDocente),
foreign key (Nominado3) references TDocentes(CodDocente),
foreign key (Nominado4) references TDocentes(CodDocente),
foreign key (Nominado5) references TDocentes(CodDocente)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA REQUISITOS
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para requisitos
create table TRequisitos
( -- lista de atributos
codRequisito varchar (10) not null,
descripcion varchar (60),
-- definicion de la clave foranea
primary key (CodRequisito)
)
Go

--------------------------------------------------------------------------
-- CREACION DE LA TABLA REQUISITOS DE SOLICITUD
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para requisitos de solicitud
create table TRequisitosSolicitud
( -- lista de atributos
codSolicitud varchar (10) not null,
codRequisito varchar (10) not null,
-- definicion de la clave foranea
foreign key (codSolicitud) references TTramites(codTramites),
foreign key (codRequisito) references TRequisitos(codRequisito),
)
Go
-------------------------------------------------------------------------
-- CREACION DE LA TABLA REQUISITOS DE EXPEDIENTE
--------------------------------------------------------------------------
use BdGestionTesis
go
-- Tabla para requisitos de solicitud
create table TExpediente
( -- lista de atributos
NroExpediente  varchar(10)not null,
Fecha date,
CodTesis varchar(10) not null,
-- definicion de la clave foranea
primary key(NroExpediente),
foreign key (CodTesis) references TTesis(CodTesis),
)
Go

 
 
 select *from TDocentes

insert into TDocentes values('D001','Emilio','Palomino','Olivera','24657893','Emilio@unsaac.edu.pe','978230232','Nombrado','Ingenieria Informatica','Disponible')
insert into TDocentes values('D002','Boris','Chullo','Llave','24542312','Boris@unsaac.edu.pe','923172100','Nombrado','Ingenieria Informatica','Disponible')
insert into TDocentes values('D003','Luis Beltran','Palma','Ttito','32785412','Luis@unsaac.edu.pe','994217622','Nombrado','Ingenieria Informatica','Disponible')
insert into TDocentes values('D004','Waldo Elio','Ibarra','Zambrano','22872131','Waldo@unsaac.edu.pe','984321276','Nombrado','Ingenieria Informatica','Disponible')
insert into TDocentes values('D005','Jose Mauro','Pillco','Quispe','20988701','Jose@unsaac.edu.pe','974560989','Nombrado','Ingenieria Informatica','Disponible')
insert into TDocentes values('D006','Karelia','Medina','Miranda','25462211','Kare@unsaac.edu.pe','907551209','Nombrado','Ingenieria Informatica','Disponible')
insert into TDocentes values('D007','Robert Wilbert','Alzamora','Paredes','26004523','Robert@unsaac.edu.pe','999458791','Nombrado','Ingenieria Informatica','Disponible')
insert into TDocentes values('D008','Maria del Pilar','Venegas','Vergara','22549001','Maria@unsaac.edu.pe','932760954','Nombrado','Ingenieria Informatica','Disponible')
insert into TDocentes values('D009','Lino Priscilo','Flores','Pacheco','25983372','Lino@unsaac.edu.pe','974122200','Nombrado','Ingenieria Informatica','Disponible')
insert into TDocentes values('D010','Javier Arturo','Rozas','Huacho','23090767','Javier@unsaac.edu.pe','994092201','Nombrado','Ingenieria Informatica','Disponible')



insert into TTesista values('012341','Mario','Huaman','Lopez','74092361','Ingenieria Informatica y de Sistemas','21/02/2004')
insert into TTesista values('091402','Luna Maria','Villa','Rosas','75980212','Ingenieria Informatica y de Sistemas','01/11/2015')
insert into TTesista values('041201','Jose Carlos','Rimas','Paredes','73090021','Ingenieria Informatica y de Sistemas','30/06/2010')
insert into TTesista values('002131','Manuel','Tintaya','Ugarte','66839012','Ingenieria Informatica y de Sistemas','15/09/2003')
insert into TTesista values('072399','Vanessa','Quispe','Salas','68094322','Ingenieria Informatica y de Sistemas','08/01/2012')
insert into TTesista values('100392','Harold Luis','Rivera','Villanueva','09328172','Ingenieria Informatica y de Sistemas','29/05/2018')
insert into TTesista values('140201','Tomas','Deza','Huamani','65094300','Ingenieria Informatica y de Sistemas','12/08/2020')
insert into TTesista values('110949','Angelica Luisa','Choque','Nina','70698764','Ingenieria Informatica y de Sistemas','09/11/2017')
insert into TTesista values('001276','Monica','Huaman','Huillca','71920973','Ingenieria Informatica y de Sistemas','26/12/2000')
insert into TTesista values('020041','Pablo Hugo','Farfan','Gutierrez','64873302','Ingenieria Informatica y de Sistemas','31/03/2008')

select *from TExpediente
insert into TExpediente values('020041','12/12/2000','T001')
insert into TTesis values('T001','Tesis sdnvdkfgnkd')
select *from TTesis