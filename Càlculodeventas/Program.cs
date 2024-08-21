using System;

class Ventas
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos al sistema de Ventas");
        Console.WriteLine("Favor ingrese su nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Favor ingrese su edad:");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Seleccione la categoría del producto a comprar:");
        Console.WriteLine("1. Carnes");
        Console.WriteLine("2. Refrescos");
        Console.WriteLine("3. Cereales (exento de impuestos)");
        string categoria = Console.ReadLine();

        double precio = 0;
        double subtotal = 0;
        double descuento = 0;
        double impuesto = 0;
        double total = 0;
        string producto;
        string tamaño;
        int cantidad;

        if (categoria == "1")
        {
            Console.WriteLine("Tenemos los siguientes productos, escriba el número deseado:");
            Console.WriteLine("1. Tajo Premium 110 lps");
            Console.WriteLine("2. Carne para bistec 90 lps");
            Console.WriteLine("3. Pollo deshuesado 60 lps");
            Console.WriteLine("4. Costilla de cerdo 120 lps");
            Console.WriteLine("5. Chuletas de cerdo 100 lps");
            producto = Console.ReadLine();
            Console.WriteLine("Seleccione el tamaño del producto:");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Mediano");
            Console.WriteLine("3. Grande");
            tamaño = Console.ReadLine();

            double precioNormal = 0;
            if (producto == "1")
                precioNormal = 110;
            else if (producto == "2")
                precioNormal = 90;
            else if (producto == "3")
                precioNormal = 60;
            else if (producto == "4")
                precioNormal = 120;
            else if (producto == "5")
                precioNormal = 100;
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado.");
                return;
            }

            if (tamaño == "1")
                precio = precioNormal;
            else if (tamaño == "2")
                precio = precioNormal * 1.25;
            else if (tamaño == "3")
                precio = precioNormal * 1.25 * 1.30;
            else
            {
                Console.WriteLine("Tamaño no válido.");
                return;
            }

            impuesto = 0.15;
        }
        else if (categoria == "2" || categoria == "3")
        {
            Console.WriteLine("Tenemos los siguientes productos, escriba el número deseado:");
            if (categoria == "2")
            {
                Console.WriteLine("1. Coca Cola 20 lps");
                Console.WriteLine("2. Fresca 18 lps");
                Console.WriteLine("3. Canada Dry 22 lps");
                Console.WriteLine("4. Pepsi 21 lps");
                Console.WriteLine("5. 7 Up  19 lps");
            }
            else if (categoria == "3")
            {
                Console.WriteLine("1. Zucaritas 85 lps");
                Console.WriteLine("2. Fruts Loops 90 lps");
                Console.WriteLine("3. Choco Crispys 95 lps");
                Console.WriteLine("4. Nestum 100 lps");
                Console.WriteLine("5. Corn Flakes 80 lps");
            }
            producto = Console.ReadLine();
            Console.WriteLine("Seleccione el tamaño del producto:");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Mediano");
            Console.WriteLine("3. Grande");
            tamaño = Console.ReadLine();

            double precioNormal = 0;
            if (categoria == "2")
            {
                if (producto == "1")
                    precioNormal = 20;
                else if (producto == "2")
                    precioNormal = 18;
                else if (producto == "3")
                    precioNormal = 22;
                else if (producto == "4")
                    precioNormal = 21;
                else if (producto == "5")
                    precioNormal = 19;
            }
            else if (categoria == "3")
            {
                if (producto == "1")
                    precioNormal = 85;
                else if (producto == "2")
                    precioNormal = 90;
                else if (producto == "3")
                    precioNormal = 95;
                else if (producto == "4")
                    precioNormal = 100;
                else if (producto == "5")
                    precioNormal = 80;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado.");
                return;
            }

            if (tamaño == "1")
                precio = precioNormal;
            else if (tamaño == "2")
                precio = precioNormal * 1.25;
            else if (tamaño == "3")
                precio = precioNormal * 1.25 * 1.30;
            else
            {
                Console.WriteLine("Tamaño no válido.");
                return;
            }

            if (categoria == "2")
                impuesto = 0.15;
            else
                impuesto = 0;
        }
        else
        {
            Console.WriteLine("El número de la categoría seleccionada no existe.");
            return;
        }

        Console.WriteLine("Ingrese la cantidad de productos:");
        cantidad = Convert.ToInt32(Console.ReadLine());

        subtotal = precio * cantidad;

        if (edad >= 65)
            descuento = subtotal * 0.30;
        else
            descuento = 0;

        double subtotalConDescuento = subtotal - descuento;
        double totalImpuesto = subtotalConDescuento * impuesto;
        total = subtotalConDescuento + totalImpuesto;

        Console.WriteLine("Subtotal: Lps " + subtotal);
        Console.WriteLine("Descuento (30% para tercera edad): Lps " + descuento);
        Console.WriteLine("Impuesto (15% si aplica): Lps " + totalImpuesto);
        Console.WriteLine("Total a pagar: Lps " + total);
    }
}
