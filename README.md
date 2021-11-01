# StuffNotes
Crea notas sobre archivos y carpetas

## Que es y por que?
StuffNotes es un programa que te permite crear notas (texto) referenciando a un archivo o carpeta.
Lo cree porque necesitaba tener resumen de porque habian tales carpetas o archivos en ciertas partes de mi computador.

## Funcionamiento
Es bastante simple.
1) Iniciar StuffNotes por primera vez.
2) Das click en el boton "Habilitar".
3) Cierras StuffNotes.
4) Das clic derecho en un archivo o capeta.
5) Aparece en el menu contextual de Windows un item llamado "StuffNotes".
6) Le das a esta opcion y aparece una ventana con un campo de texto.
7) Escribes una nota y das en el boton "Guardar nota"
8) Cierras la ventana.
9) En el futuro, das clic derecho en el mismo archivo/carpeta y vuelves a dar en "StuffNotes".
10) Aparece la ventana y el texto que habias escrito.
Esa es la esencia, tras el codigo es algo mas complejo, pero aun asi es simple.
- Al Habilitar StuffNotes con el boton de la ventana principal de StuffNotes se creara un registro en el Registro de Windows.
- Este registro se escribe en ```SOFTWARE\Classes\Directory\shell\StuffNotes``` para aparecer al dar clic derecho en una carpeta. Y en ```SOFTWARE\Classes\*\shell\StuffNotes``` para aparecer en el caso de los archivos. Todo escrito en CurrentUser (```HKEY_CURRENT_USER```)
- Luego se escribe el nombre de la opcion y el icono que aparecera. Y luego se crea la subllave ```command``` para escribir el valor que indica la ruta del ejecutable el parametro que contrendra ```Note|%V``` donde ```%V``` sera reemplazado por la ruta del elemento seleccionado.
- Luego el Inicializador leera la ruta del elemento y generara un string concatenando la ruta del elemento y su respectiva nota en la ruta ```C:\Users\USER_NAME\AppData\Local\CRZ_Labs\StuffNotesNotes``` y creara una linea dentro del archivo ```StuffWithNotes.lst```.
- Luego, al dar en el boton guardar, el archivo en la ubicacion Notes se guardara con el texto del campo principal.
- Al seleccionar el mismo elemento y llamar a StuffNotes, el Inicializador leera el parametro y vera si este elemento tiene una nota vinculada a traves de la "Base de datos" que es el archivo ```StuffWithNotes.lst```. Si tiene entonces abre la nota y la muestra, si no, entonces creara el archivo nota y luego creara la linea dentro del archivo ```StuffWithNotes.lst```.
Asi de simple. Viendo el codigo es mas facil entender.

## Worcome Studios
Comparto y autorizo a [Worcome Studios](http://worcomestudios.comule.com/) a utilizar este proyecto con el fin de ser implementado por su proyecto WorNotes (Rework).
