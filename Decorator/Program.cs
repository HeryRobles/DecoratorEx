//Creamos el componente central con tipo IComponente
//Para permitir la decoración 

using Decorator;

IComponente miAuto = new Auto("2018", "4 puertas", 200000);
IComponente miAuto2 = new Auto("2023", "2 puertas", 1600000);

Console.WriteLine(miAuto);


//Si necesitamos usar un método propio de Auto 
//necesitamos hacer uso de un type cast

((Auto)miAuto).Puertas(true);

Console.WriteLine("----------------------");


//Decoramos el auto con un sistema de Sonido:
miAuto = new SistemaSonido(miAuto);

//Comprobamos la adicion de las características:
Console.WriteLine(miAuto.Costo());
Console.WriteLine(miAuto.Funciona());
Console.WriteLine(miAuto);

Console.WriteLine("---------------------");


//Decoramos el auto con Nitrogeno:
miAuto2 = new Nitrogeno(miAuto2);

Console.WriteLine(miAuto2.Costo());
Console.WriteLine(miAuto2.Funciona());
Console.WriteLine(miAuto2);

((Nitrogeno)miAuto2).UsaNitrogeno();