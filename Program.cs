// Ejercicio 1 
/* Da la bienvenida a la UTEC a un usuario preguntale su nombre, su edad, 
 * que materias cursa y como siente su experiencia de estudios en la Universidad. 
 * (convierte la edad a entero).Luego muestra en consola los datos solicitados:
 */

//Solución

string nombreAlumno = "";  // Almacenara el nombre del usuario Author: 17-2940-2020, Abelardo Amaya
int edadAlumno = 0;    // se guardara como un numero entero Author: 17-2940-2020, Abelardo Amaya
string asignatura = ""; // esta variable va a almacenar la materia o asignatura que el usuario esta cursando Author: 17-2940-2020, Abelardo Amaya
string comentario = ""; // Esta variable almacenara el comentario del usuario acerca de su experiencia en la universidad Author: 17-2940-2020, Abelardo Amaya

//Saludo
Console.WriteLine(" Bienvenido a la Universidad Tecnologica de El Salavador (UTEC) "); //Author: 17-2940-2020, Abelardo Amaya
Console.WriteLine("*************************************************"); //Author: 17-2940-2020, Abelardo Amaya
Console.WriteLine("¡Por favor! ingrese su nombre para identificarlo:"); // Author: 17-2940-2020, Abelardo Amaya
nombreAlumno = Console.ReadLine(); // Se solicita la insercion de nombre al usuario y lo almacena en la variable nombre que habiamos inicializado Author: 17-2940-2020, Abelardo Amaya
Console.WriteLine(" Ingresa tu edad en numeros enteros:"); // Author: 17 - 2940 - 2020, Abelardo Amaya
edadAlumno = int.Parse(Console.ReadLine()); //Author: 17-2940-2020, Abelardo Amaya
Console.WriteLine("Ingrese la materia que esta cursando:") //Author: 17-2940-2020, Abelardo Amaya
asignatura = Console.ReadLine(); // Se solicita insercion de la asignatura del usuario Author: 17-2940-2020, Abelardo Amaya
Console.WriteLine("Ahora cuentenos ¿Como ha sido su experiencia desde que ingreso a la Universidad?"); //Author: 17-2940-2020, Abelardo Amaya
comentario = Console.ReadLine(); // Se solicita insercion de una breve explicación Author: 17-2940-2020, Abelardo Amaya

// impresion con interpolación Author: 17-2940-2020, Abelardo Amaya

Console.WriteLine($"\nEstudiante ingresado:\nNombre: {nombreAlumno}" + // Author: 17-2940-2020, Abelardo Amaya
    $"\nEdad: {edadAlumno} años\nMateria cursada: {asignatura}" + // Author: 17-2940-2020, Abelardo Amaya
    $"\nOpinion acerca de su experiencia en la U: {comentario}"); // Author: 17-2940-2020, Abelardo Amaya






