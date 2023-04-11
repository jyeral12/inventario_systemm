using inventario_systemm;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Sistema inventario LYR");
            List<Product> inventory = new List<Product>();
            inventory.Add(new Product { Nombre = "Laptop",  Precio = 800,   Cantidad = 503 });
            inventory.Add(new Product { Nombre = "Mochila", Precio = 950,   Cantidad = 151 });
            inventory.Add(new Product { Nombre = "Mouse",   Precio = 170,   Cantidad = 101 });
            inventory.Add(new Product { Nombre = "Teclado", Precio = 250,   Cantidad = 175 });
           


            Console.WriteLine();    

            while (true)
            {
                Console.WriteLine("1. Ver inventario");
                Console.WriteLine("2. Comprar producto");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                Console.WriteLine();

                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    // Mostrar el inventario
                    Console.WriteLine("Nombre Precio Cantidad");
                    foreach (Product product in inventory)
                    {
                        Console.WriteLine($"{product.Nombre}\t{product.Precio}\t{product.Cantidad}");
                    }
                }
                else if (option == 2)
                {
                    // Comprar un producto
                    Console.Write("Ingrese el nombre del producto: ");
                    string productName = Console.ReadLine();
                    Product selectedProduct = inventory.Find(x => x.Nombre == productName);
                    if (selectedProduct != null)
                    {
                        Console.Write("Ingrese la cantidad a comprar: ");
                        int quantity = int.Parse(Console.ReadLine());
                        if (selectedProduct.Cantidad >= quantity)
                        {
                            Console.WriteLine();
                            selectedProduct.Cantidad -= quantity;
                            Console.WriteLine($"Compra exitosa! Total a pagar: {quantity * selectedProduct.Precio}");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("No hay suficiente inventario.");
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Producto no encontrado si no esta el producto no lo ingrese porfavor.");
                        Console.WriteLine();
                    }
                }
                else if (option == 3)
                {
                    // Salir del sistema
                    break;
                  
                    Console.WriteLine("Cerrado");
                }
                else
                {
                    Console.WriteLine("Op");

                }
    }   }   }
}