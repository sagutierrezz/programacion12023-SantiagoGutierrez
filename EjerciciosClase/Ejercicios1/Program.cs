// See https://aka.ms/new-console-template for more information

////////////////////////-------------------------WHILE--------------------------///////////////////////-------------------


// 4- Para calcular el total de una factura , el usuario ingresará pares de datos Costo y Total
//; cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado.


//3- El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío, sin datos;
//el sistema informará cuántos nombres se han ingresado.

/*
string nombre = null;
int contador = 0;

Console.WriteLine("Ingresa el nombre de una persona");

while (nombre != "")
{
    nombre = Console.ReadLine();
    
    if (nombre != "")
    {
        contador++;
    }
}
Console.WriteLine($"Ingresaste un total de {contador} " );
*/




//2- Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados

/*
Console.WriteLine("Ingresa un número positivo");
string? numero;
int numeroEntero;
double suma = 0;
int contador = 0;

numero = Console.ReadLine();
numeroEntero = int.Parse(numero);

while (numeroEntero > 0)
{
    suma += numeroEntero;
    contador++;
    Console.WriteLine("Ingresa otro numero");
    numero = Console.ReadLine();
    numeroEntero = int.Parse(numero);


    if (numeroEntero == 0)
    {

        double promedio = suma / contador;
        Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);

    }
}
*/


//1 - El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0 (cero)
//El sistema deberá informar la suma de los ingresados

/*
Console.WriteLine("Ingresa un número positivo");
string? numero;
int numeroEntero;
double suma = 0;

numero = Console.ReadLine();
numeroEntero = int.Parse(numero);

while (numeroEntero > 0)
{
    suma += numeroEntero;
    Console.WriteLine("Ingresa otro numero");
    numero = Console.ReadLine();
    numeroEntero = int.Parse(numero);
    

    if (numeroEntero == 0)
    {
        Console.WriteLine("La suma de los numeros ingresados es: " + suma);

    }
}
*/




//-----------------------------------------------------------------------------------------------------------------------------//
///////////////////// --------------------------DO WHILE-------------------------------------------------------////////////////
//5-Siguiendo con el ejercicio anterior, al ingresar uno mayor o menor a 3 cifras se mostrará el promedio de los ingresados. 
/*
Console.WriteLine("Ingresa un numero");
string? numero;
int numeroEntero;
double suma = 0;
int contador = 0;
do
{
    numero = Console.ReadLine();
    numeroEntero = int.Parse(numero);
    if (numeroEntero >= 1000)
    {
        Console.WriteLine("Correcto, ingresaste un número de 4 o más cifras");
    }
    else
    {
        suma += numeroEntero;
        contador++;
        double promedio = suma / contador;
        Console.WriteLine("El promedio de los numeros ingresados hasta ahora es: " + promedio);
    }
} while (numeroEntero < 1000);
*/


//4-Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese un número mayor a 3 cifras

/*
Console.WriteLine("Ingresa un numero");
string? numero;
int numeroEntero;
do
{
    numero = Console.ReadLine();
    numeroEntero = int.Parse(numero);  

}  while (numeroEntero < 1000);

Console.WriteLine("correcto");
*/



//3-Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de los números negativos ingresados 
/*
Console.WriteLine("Inserte un numero");
string? num;
double NumDouble;
double SumaNegativos = 0;
int CantNegativos = 0;
do
{
    num = Console.ReadLine();
    NumDouble = double.Parse(num);
    if (NumDouble < 0)
    {
        SumaNegativos += NumDouble;
        CantNegativos++;
    }
} while (NumDouble <= 0);
Console.WriteLine("Correcto, ingreso un positivo");
double promedio = SumaNegativos / CantNegativos;
Console.WriteLine("El promedio de los numeros negativos ingresados es de: " + promedio);
*/


//2-Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que ingrese un positivo.
/*
using System.Drawing;

Console.WriteLine("Vas a tener que ingresar un numero");
string numero;
int numeroInt;

do
{
    numero = Console.ReadLine();
    numeroInt = int.Parse(numero);

} while (numeroInt < 0);

Console.WriteLine("Bien hecho");
*/


//1-Utilizando el DO. De esta forma utiliza un console.writeline
/*
Console.WriteLine("Ingresa una clave");
string? clave;

do
{
   clave = Console.ReadLine();
} while (clave != "667788");

Console.WriteLine("Perfecto pibe");
*/















//----------------------------------------------------------------------------------------------------------------//
//Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave,
//repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788

/*

Console.WriteLine("Ingrese una clave");
string clave = Console.ReadLine();

while (clave != 667788)
{
    Console.WriteLine("La contraseña es incorrecta, ingresá una nueva contraseña: ");
    clave = Console.ReadLine();
}
Console.WriteLine("Clave correcta");
*/


// Un alumno ingresará las notas de las 9 materias que tuvo durante el año, mostrar el Promedio de las mismas.

/*
Console.WriteLine("Te voy a pedir que ingreses las notas de las materias de tu ultimo año");
int sumita = 0;
double promedio = 0;
string notaAlumno;


for (int i = 1; i <=9; i++)
{
    Console.WriteLine("Poneme el valor de la nota" + i);
    notaAlumno = Console.ReadLine(); // El readline va para poder guardar lo que ingresa el usuario en la variable notaAlumno
    int notaAlumoInt = int.Parse(notaAlumno);

    sumita += notaAlumoInt;

    


}
promedio = sumita / 9;
Console.WriteLine("El promedio de tu ultimo año es: " + promedio);
*/

/*
Console.WriteLine("Hola, te voy a ir pidiendo los valores de los 12 meses ");
Console.WriteLine("Ingresame un valor: ");
int sumita = 0;

string valor = Console.ReadLine();
int valorInt = int.Parse(valor);

while (valorInt > 0)
{
    sumita += valorInt;

    Console.WriteLine("Ingrese un valor:");
    valor = Console.ReadLine();
    valorInt = int.Parse(valor);

}
Console.WriteLine("Al final de todo vendiste: " + sumita);
*/


/*
using System.Data.SqlTypes;

Console.WriteLine("Hola, te voy a ir pidiendo los valores de los 12 meses ");
int sumita = 0;
for (int mes = 1; mes <=12; mes++)
{
    Console.WriteLine("Poneme el valor del mes: " + mes);
    string valor = Console.ReadLine();
    sumita += int.Parse(valor);

}
Console.WriteLine(sumita);
*/




/*
string LoQueElFlacoPone;

Console.WriteLine("Hola me das una cadea de caracteres: ");
LoQueElFlacoPone = Console.ReadLine();

if (LoQueElFlacoPone.Length > 15)
{
    Console.WriteLine("Mucho texto");

} else
{
    Console.WriteLine("Bien, tiene pocos caracteres");
}
*/




/*
Console.WriteLine("Hola, me decis tu año de nacimiento");
string edad = Console.ReadLine();
int edadDelPibeEnInt = int.Parse(edad);
int edad_actual = 2023 - edadDelPibeEnInt;
int edadLaza = 23;
Console.WriteLine("Vos vas a cumplir este año: {0} y la edad de laza es {1}", edad_actual, edadLaza);
*/