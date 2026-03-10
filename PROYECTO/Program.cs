void menuPrincipal()
{
    int option = 0;
    do
    {
        Console.WriteLine("   Menú Principal Vick´s Prime   ");
        Console.WriteLine("Bienvenido al menú princilap de Vick´s Prime");
        Console.WriteLine("Cual de las opciones desea elejir?");
        Console.WriteLine("\n1.Evaluar Contenido\n 2.Politicas\n 3.Estadisticas\n 4.Reiniciar Estadisticas\n 5.Salis.");
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                pedirDatosUno();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }

        void pedirDatosUno()
        {
            Console.WriteLine("Ingrese el tipo de contenido (1.película, 2.serie, 3.documental, 4.evento en vivo):");
            int tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    Console.WriteLine("ingrese el nombre de la pelicula");
                    string nombrePelicula = Console.ReadLine();
                    Console.WriteLine("Cual es la duración de la pelicula?");
                    int duracionPeli = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la clasificación ( 1) todo público, 2) +13, 3) +18. )");
                    int clasificacion1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la hora programada (0-23):");
                    int hora1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nivel de Producción (1.bajo, 2.medio, 3.alto)");
                    int produccion1 = int.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Ingrese el nombre de la Serie");
                    string nombreSerie = Console.ReadLine();
                    Console.WriteLine("Cual es la duración de la Serie?");
                    int duracionSerie = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la clasificación (1.TP, 2.+13, 3.+18)");
                    int clasificacion2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la hora programada:");
                    int hora2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nivel de Producción (1.bajo, 2.medio, 3.alto)");
                    int produccion2 = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre del Documental");
                    string nombreDocumental = Console.ReadLine();
                    Console.WriteLine("Cual es la duración del Documental?");
                    int duracionDocu = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la clasificación (1.TP, 2.+13, 3.+18)");
                    int clasificacion3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la hora programada:");
                    int hora3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nivel de Producción (1.bajo, 2.medio, 3.alto)");
                    int produccion3 = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre del evento en vivo");
                    string nombreEvento = Console.ReadLine();
                    Console.WriteLine("Cual es la duración del evento en vivo?");
                    int duracionEvento = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la clasificación (1.TP, 2.+13, 3.+18)");
                    int clasificacion4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la hora programada:");
                    int hora4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nivel de Producción (1.bajo, 2.medio, 3.alto)");
                    int produccion4 = int.Parse(Console.ReadLine());
                    break;
                default:
                    break;
            }
        }
    } while (option != 5);
}
menuPrincipal();
