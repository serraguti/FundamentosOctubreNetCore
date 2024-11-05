--COMENTARIOS
--CONSULTAS BASICAS SELECT
--DEVUELVEN TODAS LAS COLUMNAS Y TODOS LOS DATOS DE UNA TABLA
SELECT * FROM EMP
select * from dept
--PODEMOS INDICAR QUE COLUMNAS DESEAMOS RECUPERAR
select APELLIDO, OFICIO, SALARIO from EMP
--PODEMOS ORDENAR LOS DATOS DE FORMA ASCENDENTE O DESCENDENTE
--order by COLUMNA ASC/DESC
--ORDENAMOS LOS APELLIDOS DE LOS EMPLEADOS DE FORMA ASCENDENTE
select * from EMP order by APELLIDO asc
--ORDENAMOS LOS APELLIDOS DE LOS EMPLEADOS DE FORMA DESCENDENTE
select * from EMP order by APELLIDO desc
--FILTRADO DE DATOS: where
--NOS PERMITE FILTRAR LOS DATOS DE LA TABLA.  SOLAMENTE TENDREMOS UN 
--WHERE EN TODA LA CONSULTA
--SE UTILIZAN OPERADORES DE COMPARACION
/*
	> MAYOR
	< MENOR
	>= MAYOR O IGUAL
	<= MENOR O IGUAL
	=  IGUAL
	<> DISTINTO
*/
--TODO LO QUE NO SEA UN NUMERO SE COMPARA MEDIANTE COMILLAS SIMPLES
--MOSTRAR TODOS LOS EMPLEADOS DEL DEPARTAMENTO 30
select * from EMP where DEPT_NO=30
--MOSTRAR TODOS LOS EMPLEADOS CON OFICIO ANALISTA
select * from EMP where OFICIO='ANALISTA'
--SI NECESITAMOS MAS DE UN FILTRO, DEBEMOS UTILIZAR LOS OPERADORES RELACIONALES
/*
	AND: TODOS LOS FILTROS DEBEN CUMPLIRSE
	OR: MUESTRA DATOS DE CADA FILTRO
	NOT: NEGACION DE UNA CONSULTA
*/
--MOSTRAR TODOS LOS EMPLEADOS CON OFICIO ANALISTA Y QUE COBREN MAS DE 300.000
select * from EMP where OFICIO='ANALISTA' AND SALARIO>300000
--EL OPERADOR OR SE SUELE UTILIZAR PARA COMPARAR VALORES SOBRE UN SOLO CAMPO/COLUMNA
--MOSTRAR LOS EMPLEADOS DEL DEPARTAMENTO 10 Y DEL DEPARTAMENTO 20
select * from EMP where DEPT_NO=10 or DEPT_NO=20
--EL OPERADOR NOT NUNCA LO VAMOS A UTILIZAR, RALENTIZA LA CONSULTA.
--MOSTRAR TODOS LOS EMPLEADOS QUE NO SEAN DIRECTOR
select * from EMP where NOT OFICIO='DIRECTOR'
--LA FORMA CORRECTA SER UTILIZAR SIEMPRE LOS OPERADORES
select * from EMP where OFICIO <> 'DIRECTOR'
--OTROS OPERADORES DE COMPARACION
--between: BUSCA ENTRE DOS VALORES DE UN CAMPO INCLUSIVE
--MOSTRAR TODOS LOS EMPLEADOS CUYO SALARIO ESTE ENTRE 208.000 Y 300.000
select * from EMP where SALARIO between 208000 and 300000
--OPERADOR IN: BUSCA COINCIDENCIAS DE IGUALDAD PARA UN MISMO CAMPO/COLUMNA
--MOSTRAR TODOS LOS EMPLEADOS DEL DEPARTAMENTO 10 Y 20 Y DEL 30, 99, 88, 77
select * from EMP where DEPT_NO=10 or DEPT_NO=20 or DEPT_NO=30
or DEPT_NO=99 or DEPT_NO=88 or DEPT_NO=77
--EL OPERADOR IN, NOS PERMITE SIMPLIFICAR LA CONSULTA IN (VALOR1, VALOR2)
select * from EMP where DEPT_NO in (10, 20, 30, 77, 88, 99)
--OPERADOR LIKE: BUSCA COINCIDENCIAS EN UNA COLUMNA TEXTO
-- _ BUSCAR CUALQUIER CARACTER
-- ? BUSCAR UN CARACTER NUMERICO EN EL TEXTO
-- % BUSCAR CUALQUIER CARACTER Y LONGITUD
--MOSTRAR TODOS LOS EMPLEADOS CUYO APELLIDO COMIENCE EN A
select * from EMP where APELLIDO like 'A%'
--MOSTRAR TODOS LOS EMPLEADOS CUYO APELLIDO CONTENGA LA LETRA A
select * from EMP where APELLIDO like '%A%'
--MOSTRAR TODOS LOS EMPLEADOS CUYO APELLIDO SEA DE 4 LETRAS
select * from EMP where APELLIDO like '____'
--CAMPOS CALCULADOS
--SON COLUMNAS QUE NO EXISTEN EN LA BASE DE DATOS Y QUE SE CALCULAN 
--CON OTRAS COLUMNAS DE LA BASE DE DATOS.
--DEBEMOS INDICAR UN ALIAS PARA LOS CAMPOS CALCULADOS
--NO PODEMOS TENER ESPACIOS EN LOS ALIAS Y NO PODEMOS TENER NOMBRES
--DE COLUMNAS REPETIDAS EN UNA MISMA CONSULTA
--MOSTRAR EL SALARIO TOTAL (SALARIO + COMISION) DE LOS EMPLEADOS DE LA TABLA
select APELLIDO, SALARIO, COMISION, SALARIO + COMISION as TOTAL from EMP
--TAMBIEN PODEMOS CONCATENAR CAMPOS DE TEXTO MEDIANTE EL SIMBOLO +
--MOSTRAR EL APELLIDO Y EL OFICIO DE LOS EMPLEADOS EN UNA SOLA COLUMNA
--LLAMADA DESCRIPCION
select APELLIDO + ' ' + OFICIO as DESCRIPCION from EMP
--CLAUSULA DISTINCT
--ELIMINA RESULTADOS REPETIDOS DE UNA CONSULTA
--SE UTILIZA PARA MOSTRAR DATOS SIN REPETIDOS DE UN GRUPO
--MOSTRAR EL OFICIO DE LOS EMPLEADOS
select OFICIO from EMP
select DISTINCT OFICIO from EMP




