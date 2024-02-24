using System;

class Program
{
    static void Main(string[] args)
    {
        // Calcular el Mayor de Tres Números
        Console.Clear();
        Console.WriteLine("Ingresa tres numeros:");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());

        double max = Math.Max(num1, Math.Max(num2, num3));

        Console.WriteLine($"El numero mayor es: {max}");
        
        

        // Validar Edad para Ingresar a un Club
        Console.WriteLine("Ingrese tu edad:");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Bienvenido al club.");
        }
        else
        {
            Console.WriteLine("Debes ser mayor de 18 años para entrar al club.");
        }
        Console.ReadLine();
        

        // Calcular el Precio Final de un Producto
        Console.WriteLine("Ingrese el precio original del producto:");
        double precioOriginal = double.Parse(Console.ReadLine());

        if (precioOriginal > 100)
        {
            double descuento = precioOriginal * 0.10;
            double precioFinal = precioOriginal - descuento;
            Console.WriteLine($"Precio con descuento: {precioFinal}");
        }
        else
        {
            Console.WriteLine($"El precio final es: {precioOriginal}");
        }
        
        Console.ReadLine();
       

        // Validar Usuario y Contraseña
        Console.WriteLine("Ingrese su usuario:");
        string usuario = Console.ReadLine();
        Console.WriteLine("Ingrese su contraseña:");
        string contraseña = Console.ReadLine();

        if (usuario == "usuario" && contraseña == "contraseña")
        {
            Console.WriteLine("Acceso concedido.");
        }
        else
        {
            Console.WriteLine("Nombre de usuario o contraseña incorrectos.");
        }
        Console.ReadLine();
        

        // Determinar si un Número es Par o Impar
        Console.WriteLine("Ingrese un número:");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
        Console.ReadLine();
        

        // Mostrar un Mensaje de Aprobación o Rechazo de Préstamo
        Console.WriteLine("Ingrese el monto del préstamo:");
        double montoPrestamo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su edad:");
        edad = int.Parse(Console.ReadLine());

        if (montoPrestamo < 5000 || edad > 60)
        {
            Console.WriteLine("Préstamo aprobado.");
        }
        else
        {
            Console.WriteLine("Préstamo rechazado.");
        }
        Console.ReadLine();
        

        // Calcular el Área de una Figura Geométrica
        Console.WriteLine("Ingrese el tipo de figura geométrica (triangulo, cuadrado, circulo):");
        string figura = Console.ReadLine().ToLower();

        switch (figura)
        {
            case "triangulo":
                Console.WriteLine("Ingrese la base del triángulo:");
                double baseTriangulo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triángulo:");
                double alturaTriangulo = double.Parse(Console.ReadLine());
                double areaTriangulo = 0.5 * baseTriangulo * alturaTriangulo;
                Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
                break;

            case "cuadrado":
                Console.WriteLine("Ingrese el lado del cuadrado:");
                double ladoCuadrado = double.Parse(Console.ReadLine());
                double areaCuadrado = ladoCuadrado * ladoCuadrado;
                Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");
                break;

            case "circulo":
                Console.WriteLine("Ingrese el radio del círculo:");
                double radioCirculo = double.Parse(Console.ReadLine());
                double areaCirculo = Math.PI * radioCirculo * radioCirculo;
                Console.WriteLine($"El área del círculo es: {areaCirculo}");
                break;

            default:
                Console.WriteLine("Figura no reconocida.");
                break;
        }
      
        Console.ReadLine();
       

        // Ejercicio 1: Convertir un número de letra a número
        Console.WriteLine("Ejercicio 1: Convertir un número de letra a número");
        Console.WriteLine("Ingrese un número del 1 al 5 en letra:");
        string numeroEnLetra = Console.ReadLine().ToLower(); // Convertimos a minúsculas para evitar problemas de mayúsculas
        switch (numeroEnLetra)
        {
            case "uno":
                Console.WriteLine("Número en dígito: 1");
                break;
            case "dos":
                Console.WriteLine("Número en dígito: 2");
                break;
            case "tres":
                Console.WriteLine("Número en dígito: 3");
                break;
            case "cuatro":
                Console.WriteLine("Número en dígito: 4");
                break;
            case "cinco":
                Console.WriteLine("Número en dígito: 5");
                break;
            default:
                Console.WriteLine("Número no válido.");
                break;
        }

        // Ejercicio 2: Mostrar el día de la semana a partir de un número
        Console.WriteLine("\nEjercicio 2: Mostrar el día de la semana a partir de un número");
        Console.WriteLine("Ingrese un número del 1 al 7:");
        int numeroDiaSemana = Convert.ToInt32(Console.ReadLine());
        switch (numeroDiaSemana)
        {
            case 1:
                Console.WriteLine("Día de la semana: Lunes");
                break;
            case 2:
                Console.WriteLine("Día de la semana: Martes");
                break;
            case 3:
                Console.WriteLine("Día de la semana: Miércoles");
                break;
            case 4:
                Console.WriteLine("Día de la semana: Jueves");
                break;
            case 5:
                Console.WriteLine("Día de la semana: Viernes");
                break;
            case 6:
                Console.WriteLine("Día de la semana: Sábado");
                break;
            case 7:
                Console.WriteLine("Día de la semana: Domingo");
                break;
            default:
                Console.WriteLine("Número no válido.");
                break;
        }

        // Ejercicio 3: Calcular el importe a pagar por un servicio
        Console.WriteLine("\nEjercicio 3: Calcular el importe a pagar por un servicio");
        Console.WriteLine("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revisión mecánica):");
        string tipoServicio = Console.ReadLine().ToLower();
        switch (tipoServicio)
        {
            case "lavado de auto":
                Console.WriteLine("Importe a pagar: $10");
                break;
            case "cambio de aceite":
                Console.WriteLine("Importe a pagar: $20");
                break;
            case "revisión mecánica":
                Console.WriteLine("Importe a pagar: $30");
                break;
            default:
                Console.WriteLine("Tipo de servicio no válido.");
                break;
        }

        // Ejercicio 4: Mostrar un mensaje de bienvenida en diferentes idiomas
        Console.WriteLine("\nEjercicio 4: Mostrar un mensaje de bienvenida en diferentes idiomas");
        Console.WriteLine("Ingrese su idioma de preferencia (español, inglés, francés):");
        string idioma = Console.ReadLine().ToLower();
        switch (idioma)
        {
            case "español":
                Console.WriteLine("¡Bienvenido!");
                break;
            case "inglés":
                Console.WriteLine("Welcome!");
                break;
            case "francés":
                Console.WriteLine("Bienvenue!");
                break;
            default:
                Console.WriteLine("Idioma no válido.");
                break;
        }

        // Ejercicio 5: Evaluar la calificación de un examen
        Console.WriteLine("\nEjercicio 5: Evaluar la calificación de un examen");
        Console.WriteLine("Ingrese la calificación del examen:");
        int calificacion = Convert.ToInt32(Console.ReadLine());
        switch (calificacion)
        {
            case int n when (n >= 90 && n <= 100):
                Console.WriteLine("Desempeño: Sobresaliente");
                break;
            case int n when (n >= 80 && n <= 89):
                Console.WriteLine("Desempeño: Notable");
                break;
            case int n when (n >= 70 && n <= 79):
                Console.WriteLine("Desempeño: Aprobatoria");
                break;
            case int n when (n >= 60 && n <= 69):
                Console.WriteLine("Desempeño: No aprobatoria");
                break;
            default:
                Console.WriteLine("Calificación no válida.");
                break;
        }
    }
}
