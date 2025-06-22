// Ejercicio 1 
/* Da la bienvenida a la UTEC a un usuario preguntale su nombre, su edad, 
 * que materias cursa y como siente su experiencia de estudios en la Universidad. 
 * (convierte la edad a entero).Luego muestra en consola los datos solicitados:
 */

//Solución


string nombreAlumno = "";  // Almacenara el nombre del usuario
int edadAlumno = 0;    // se guardara como un numero entero 
string asignatura = ""; // esta variable va a almacenar la materia o asignatura que el usuario esta cursando
string comentario = ""; // Esta variable almacenara el comentario del usuario acerca de su experiencia en la universidad

//Saludo
Console.WriteLine(" Bienvenido a la Universidad Tecnologica de El Salavador (UTEC) ");
Console.WriteLine("*************************************************");
Console.WriteLine("¡Por favor! ingrese su nombre para identificarlo:");
nombreAlumno = Console.ReadLine(); // Se solicita la insercion de nombre al usuario y lo almacena en la variable nombre que habiamos inicializado
Console.WriteLine(" Ingresa tu edad en numeros enteros:");
edadAlumno = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la materia que esta cursando:");
asignatura = Console.ReadLine(); // Se solicita insercion de la asignatura del usuario
Console.WriteLine("Ahora cuentenos ¿Como ha sido su experiencia desde que ingreso a la Universidad?");
comentario = Console.ReadLine(); // Se solicita insercion de una breve explicación 

// impresion con interpolación

Console.WriteLine($"\nEstudiante ingresado:\nNombre: {nombreAlumno}" +
    $"\nEdad: {edadAlumno} años\nMateria cursada: {asignatura}" +
    $"\nOpinion acerca de su experiencia en la U: {comentario}");






