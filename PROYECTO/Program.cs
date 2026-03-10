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
            bool cumpleDuracion = false;
            bool cumpleHora=false;
            bool cumpleProduccion=true;
            switch (tipo)
            {
                case 1:
                    Console.WriteLine("ingrese el nombre de la pelicula");
                    string nombrePelicula = Console.ReadLine();
                    Console.WriteLine("Cual es la duración de la pelicula?");
                    int duracionPeli = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la clasificación ( 1.- todo público, 2.- +13, 3.- +18 )");
                    int clasificacionUNO = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la hora programada (0-23):");
                    int horaUno = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nivel de Producción (1.bajo, 2.medio, 3.alto)");
                    int produccionUno = int.Parse(Console.ReadLine());
                    if (duracionPeli >= 60 && duracionPeli <= 180)
                    {
                        cumpleDuracion = true;
                    }
                    if (clasificacionUNO == 1)
                    { 
                        cumpleHora = true;
                    }
                    if (clasificacionUNO == 2 && horaUno >= 6 && horaUno <= 22)
                    {
                        cumpleHora=true;
                    }
                    if (clasificacionUNO == 3 && horaUno >= 22 || horaUno <= 5)
                    {
                        cumpleHora=true;
                    }
                    if (produccionUno == 1 && clasificacionUNO == 3)
                    {
                        cumpleProduccion = false;
                    }
                        break;
                case 2:
                    Console.WriteLine("Ingrese el nombre de la Serie");
                    string nombreSerie = Console.ReadLine();
                    Console.WriteLine("Cual es la duración de la Serie?");
                    int duracionSerie = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la clasificación (1.Todo publico, 2.+13, 3.+18)");
                    int clasificacionDOS = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la hora programada:");
                    int horaDos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nivel de Producción (1.bajo, 2.medio, 3.alto)");
                    int produccionDos = int.Parse(Console.ReadLine());
                    if (duracionSerie >= 20 && duracionSerie <=90)
                    {
                        cumpleDuracion = true;
                    }
                    if (clasificacionDOS == 1)
                    {
                        cumpleHora=true;
                    }
                    if (clasificacionDOS == 2 && horaDos >= 6 && horaDos <= 22)
                    {
                        cumpleHora = true;
                    }
                    if (clasificacionDOS == 3 && horaDos >= 22 || horaDos <= 5)
                    {
                        cumpleHora = true;
                    }
                    if (produccionDos == 1 && clasificacionDOS == 3)
                    {
                        cumpleProduccion = false;
                    }

                    break;
                case 3:
                    Console.WriteLine("Ingrese el nombre del Documental");
                    string nombreDocumental = Console.ReadLine();
                    Console.WriteLine("Cual es la duración del Documental?");
                    int duracionDocu = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la clasificación (1.Todo publico, 2.+13, 3.+18)");
                    int clasificacionTres = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la hora programada:");
                    int horaTres = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nivel de Producción (1.bajo, 2.medio, 3.alto)");
                    int produccionTres = int.Parse(Console.ReadLine());
                    if (duracionDocu >=30 && duracionDocu <= 120)
                    {
                        cumpleDuracion=true;
                    }
                    if (clasificacionTres == 1)
                    {
                        cumpleHora=true;
                    }
                    if (clasificacionTres == 2 && horaTres >= 6 && horaTres <= 22)
                    {
                        cumpleHora=true;
                    }
                    if (clasificacionTres == 3 && horaTres >= 22 || horaTres <= 5)
                    {
                        cumpleHora=true;
                    }
                    if (produccionTres == 1 && clasificacionTres == 3)
                    {
                        cumpleProduccion = false;
                    }
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nombre del evento en vivo");
                    string nombreEvento = Console.ReadLine();
                    Console.WriteLine("Cual es la duración del evento en vivo?");
                    int duracionEvento = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese la clasificación (1.Todo publico, 2.+13, 3.+18)");
                    int clasificacionCuatro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la hora programada:");
                    int horaCuatro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nivel de Producción (1.bajo, 2.medio, 3.alto)");
                    int produccionCuatro = int.Parse(Console.ReadLine());
                    if (duracionEvento >= 30 && duracionEvento <= 120)
                    {
                        cumpleDuracion = true;
                    }
                    if (clasificacionCuatro == 1)
                    {
                        cumpleHora = true;
                    }
                    if (clasificacionCuatro == 2 && horaCuatro >= 6 && horaCuatro <= 22)
                    {
                        cumpleHora = true;
                    }
                    if (clasificacionCuatro == 3 && horaCuatro >= 22 || horaCuatro <= 5)
                    {
                        cumpleHora = true;
                    }
                    if (produccionCuatro == 1 && clasificacionCuatro == 3)
                    {
                        cumpleProduccion = false;
                    }
                    break;
                default:
                    break;
            }
            if (cumpleDuracion && cumpleHora && cumpleProduccion)
            {
                Console.WriteLine(" Validación Exitosa");
            }
            else
            {
                Console.WriteLine("Error, no cumple las reglas ");
            }
        }
    } while (option != 5);
}
menuPrincipal();
