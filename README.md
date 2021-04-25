# ExamenIngresoAbril-2021

1)Por favor, especifica tu nombre completo: Gabriel M. Bermudez

2)En C#, ¿para qué sirve una propiedad?. Una propiedad permite acceder a los datos del atributo, como asi tambien modificar su contenido.

3)¿Cuándo utilizaría acceso protegido en los miembros de una clase?
El acceso protegido lo utilizaria para acceder a los atributos de la clase actual o de sus clases derivadas, claro ejemplo de herencia.

4) En UML, ¿qué tipo de relación es la siguiente?
 
Esta relacion hace referencia al concepto de herencia, que consiste en una clase hijo que usa los atributos y/o metodos de la clase padre.

5) Explique con sus palabras qué implica una relación de Dependencia entre dos clases.
Al haber dependencia entre dos clases, existe una, solamente si existe la otra.

6)Indique V o F según corresponda. Si es F, fundamente su respuesta:
	a.Un constructor es un método que se invoca de forma automática cuando se instancia el objeto de la clase. V
	b.Un constructor debe tener siempre el mismo nombre de la clase. V
	c.Un constructor puede retornar un valor. F porque no tiene un tipo de dato definido
	d.Un constructor puede ser privado. V
	e.Una clase sólo puede tener declarado un único constructor. F una clase puede tener sobrecarga de constructores, siendo ideal crear uno vacio al implementar multiples constructores



Manual de uso
1) El programa inicia con la clase Biblioteca
2) El programa indica tres opciones:
	a. Menu Libro: Accede a los libros disponibles
	b. Menu Socio: Permite dar de alta un socio comun, socios VIP, y mostrar los socios creados para ejecutar operaciones sobre ellos
	c. Mostrar Prestamos: En caso de haber algun prestamo registrado, mostrara una tabla con los mismos

Menu Libro: Al colocar el ID de un libro, podra consultar ejemplares disponibles, agregar ejemplares.

Menu Socio: Al mostrar los socios, podra elegir uno mediante el ID de la tabla, lo cual le permitira abrir un nuevo menu, en el que podra consultar su cupo disponible, pedir prestado y/o devolver un libro.

Si selecciona pedir un libro prestado, le mostrara los libros disponibles permitiendo elegir uno mediante el ID, luego se le habilitara las opciones del menu del libro, para consultar ejemplares disponibles, pedir prestado ese libro, o devolverlo.

En caso de elegir devolver libro, le mostrara una grilla con los libros que posee, permitiendo elegir uno mediante el ID de la tabla y realizando la devolucion del mismo. 


