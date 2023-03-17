using System;

namespace matrices
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("****Taller Algoritmos****");

            Console.WriteLine("Digite 1 para crear una matriz de 3 por 5, cargar sus elementos y luego imprimirlas.\n" +
                "Digite 2 para ver la diagonal principal de la matriz\n" +
                "Digite 3 para Para ingresar filas y columnas y luego imprimir los lados de la matriz.\n");

            int respuesta = Convert.ToInt32(Console.ReadLine());


            switch (respuesta)
            {
                case 1:
                    Matriz3x5();
                    break;
                case 2:
                    Diagonal();
                    break;
                case 3:
                    colxfilas();
                    break;
                default:
                    Console.Write("\t Opción no válida...");
                    break;
            }

        }

        public static void Matriz3x5()
        {
            //se crea la matriz de 3x4 de tipo entero
            int[,] matriz = new int[3, 5];
            // se llena la matriz
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"Ingrese el valor de posicion {f} {c}: ");
                    string linea = Console.ReadLine();
                    //se utiliza el int.parse, para convertir el valor leído
                    matriz[f, c] = int.Parse(linea);
                }
            }
            //mostrar la información que se guarda en la matriz
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine($"La posicion {f},{c} tiene el valor[{matriz[f, c]}], ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void Diagonal()
        {
            try
            {
                int filas = 5;
                int columnas = 5;
                double[,] matrix = new double[filas, columnas];

                //matrix[0, 0] = 1;
                //matrix[1, 1] = 2;
                //matrix[2, 2] = 1;
                //matrix[3, 3] = 1;
                //matrix[4, 4] = 1;
                var count = 4;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        int valor = 0;
                        if (i == j)
                        {

                            Console.WriteLine($"Ingrese el número de la posición {i}, {j} ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            matrix[i, j] = valor;
                        }
                        else if (j == count)
                        {

                            Console.WriteLine($"Ingrese el número de la posición {i}, {j} ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            matrix[i, j] = valor;
                        }
                        else
                            matrix[i, j] = 0;

                        //Console.Write($"{matrix[i, i]}    ");

                    }
                    //Console.Write("\n");
                    count -= 1;

                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {


                        //if(i == j)
                        //    matrix[i, i] = i + 1;
                        //else if(j == count)
                        //   matrix[i, i] = i + 1;
                        //else
                        //    matrix[i, i] = 0;

                        Console.Write($"{matrix[i, j]}    ");

                    }
                    Console.Write("\n");
                    //count -= 1;

                }
            }
            catch (Exception ex)
            {


            }

        }

        public static void colxfilas()
        {

            Console.WriteLine("Ingrese el tamaño de las filas de la matriz");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tamaño de las columnas de la matriz");
            int columnas = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];


            double[,] matrix = new double[filas, columnas];

            var count = 1;
            var ultimo = 6;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    //if(i == 0 && i == 1)
                    //   matriz[i, j] = j+1;
                    //else
                    //   matriz[i, j] = 0;

                    matrix[0, j] = j + 1;
                    matrix[i, 0] = count;
                    matrix[i, columnas - 1] = ultimo;
                    matrix[filas - 1, i] = ultimo;

                    Console.Write($"{matrix[i, j]}    ");

                }
                Console.Write("\n");
                count += 1;
                ultimo -= 1;

            }
        }
    }
}

