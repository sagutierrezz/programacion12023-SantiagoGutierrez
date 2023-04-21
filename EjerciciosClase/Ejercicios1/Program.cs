// See https://aka.ms/new-console-template for more information

//----------------------------------------FOR---------------------------------------------//

// 5- El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado, indicar el cliente que gastó más.

/*
int elMayorGasto = 0;
string elNombreDelFlacoQueMasGasto = "";

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Porfa ingreseme el nombre del pibe ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Porfa ingreseme cuanto gastó ");
    int gasto = int.Parse(Console.ReadLine());

    if (gasto > elMayorGasto)
    {
        // Aca tengo un nuevo gasto mayor, así que tengo que hacer 2 cosas
        // una es ahora tener este nuevo gasto como mayor
        // y lo otro es no perder el nombre del flaco, porque me piden que al final
        // diga quien es este pibe que mas gastó
        elMayorGasto = gasto;
        elNombreDelFlacoQueMasGasto = nombre;
    }
}
Console.WriteLine("El pibe que más gastó fue " + elNombreDelFlacoQueMasGasto);
Console.WriteLine(" Y el total que gastó fue " + elMayorGasto);
*/

// 4- De una lista de 8 números indicar cual es el mayor

/*
int[] numeros = new int[] { 5, 2, 10, 8, 1, 9, 4, 7 };

int maximo = numeros[0]; //toma como máximo el primer valor de la lista, para luego en cada iteración compararlo con el elemento que sigue de la lista

for (int i = 1; i < numeros.Length; i++) ??// mientras i sea menor a la cantidad de elementos de la lista se ejecutará, cuando i es mayor a la cantidad de elementos de la lista, finaliza el bucle
{
    if (numeros[i] > maximo) 
    {
        maximo = numeros[i]; // si el elemento de la lista es mayor que maximo lo guarda en la variable 'maximo'
    }
}

Console.WriteLine($"El número máximo de la lista 'numeros' es: {maximo}");
*/


// 3- Para calcular el total de una factura , el usuario ingresará pares de datos Costo y Total ;
// de unas 5 compras; informar el total adeudado.

/*
Console.WriteLine("Porfa ingreseme el costo");
string costo = Console.ReadLine();
int costoNum = int.Parse(costo);
int sumita = 0;

for (int i = 0; i < 5; i++)
{

    Console.WriteLine("Ahora poneme el total");
    string total = Console.ReadLine();
    int totalNum = int.Parse(total);

    
    sumita = sumita + (costoNum * totalNum);

    Console.WriteLine("Porfa ingreseme el costo");
    costo = Console.ReadLine();
    costoNum = int.Parse(costo);
}

Console.WriteLine("Flaco , pusiste: " + sumita);
*/



// 2- Se necesita calcular el promedio de 8 números ingresados por el usuario

/*
int numero = 0;
int suma = 0;
double promedio = 0;
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Ingresa un numero");
    numero = int.Parse(Console.ReadLine());

    suma += numero;

    
}
promedio = suma / 8;
Console.WriteLine($"El promedio de los numeros ingresados es: {promedio}");
*/


// 1- El usuario necesita ingresar 5 valores enteros, el sistema deberá informar la suma de los 5

/*
int numero = 0;
int suma = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Ingresa un numero");
    numero = int.Parse(Console.ReadLine());

    suma += numero;
}
Console.WriteLine($"La suma de los 5 numeros es: {suma}");
*/




////////////////////////-------------------------WHILE--------------------------///////////////////////-------------------


// 5- Para calcular el consumo total de un cliente, el usuario primero ingresará cuántos productos compró;
// luego el sistema solicitará que ingrese el total y costo de cada uno de esos productos consumidos;
// al terminar informará el total adeudado por el cliente. 

/*
int cantidadProductos;
double costoProducto, totalProducto, Total = 0;

Console.Write("Ingrese la cantidad de productos: ");
cantidadProductos = int.Parse(Console.ReadLine());

int i = 1; //Inicializo i en 1 para que el primer write del while comience en 1
while (i <= cantidadProductos) 
{
    Console.Write($"Ingrese el costo del producto {i}: ");
    costoProducto = double.Parse(Console.ReadLine());

    Console.Write($"Ingrese el total del producto {i}: ");
    totalProducto = double.Parse(Console.ReadLine());

    Total += (totalProducto - costoProducto);
    i++;
}

Console.WriteLine($"El total adeudado por el cliente es: {Total}");
*/

// 4- Para calcular el total de una factura , el usuario ingresará pares de datos Costo y Total
//; cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado.

/*
Console.WriteLine("Porfa ingreseme el costo");
string costo = Console.ReadLine();
int costoNum = int.Parse(costo);
int sumita = 0;

while (costoNum > 0)
{

    Console.WriteLine("Ahora poneme el total");
    string total = Console.ReadLine();
    int totalNum = int.Parse(total);

    // En estancia yo ya tengo ingresado al menos 1 par de costo y total
    // así ´que acá sería un buen momento de hacer mi proceso
    sumita = sumita + (costoNum * totalNum);

    Console.WriteLine("Porfa ingreseme el costo");
    costo = Console.ReadLine();
    costoNum = int.Parse(costo);
}

Console.WriteLine("Flaco , pusiste: " + sumita);
*/

// 3- El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío, sin datos;
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




// 2- Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados

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


// 1 - El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0 (cero)
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


//1- Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave,
//repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788

/*
Console.WriteLine("Ingresa una clave");
string? clave;

do
{
   clave = Console.ReadLine();
} while (clave != "667788");

Console.WriteLine("Perfecto pibe");
*/









//---------------------Ejercicios de la primer clase-------------------------------------------------------------------//
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