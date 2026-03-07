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
                pedirDatos();
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

        void pedirDatos()
        {
            Console.WriteLine("Ingrese el tipo de contenido (1.película, 2.serie, 3.documental, 4.evento en vivo):");
            int tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    Console.WriteLine("ingrese el nombre de la pelicula");
                    string nombrePelicula = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Ingrese el nombre de la Serie");
                    string nombreSerie = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre del Documental");
                    string nombreDocumental = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre del evento en vivo");
                    string nombreVivo = Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    } while (option != 5);
}
menuPrincipal();
