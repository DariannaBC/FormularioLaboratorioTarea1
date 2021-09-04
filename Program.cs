using System;

namespace Tarea1Aplicada
{
    class Program
    {
        static void Main(string[] args)
     { int seleccion;
            Console.WriteLine("Seleccione el ejercicio que desea realizar: \n1-Cap 1 Ejercicio 1\n2-Cap 1 Ejercicio 5\n3-Cap 2 Ejercicio 1\n4-Cap 2 Ejercicio 3\n5-Cap 2 Ejercicio 5\n6-Cap 3 Ejercicio 1\n7-Cap 3 Ejercicio 4");
            seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Darianna Cruz De La Rosa");
                    break;

                case 2:
                    Console.WriteLine("Darianna Cruz De La Rosa");
                    Console.WriteLine("Junior Emmanuel Baez Tavarez");
                    break;

                case 3:
                    Perimetro();
                    break;

                case 4:
                    Radianes();
                    break;


                case 5:
                    dolareseuros();
                    break;

                case 6:
                    parimpar();
                    break;

                case 7:
                    semana();
                    break;

                default:
                    break;
            }
        }


       
      

        public static void Perimetro()
        {
            int l, p, la;
            Console.WriteLine("Ingresa una Longitud");
            l = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingresa un lado");
            la = Convert.ToInt16(Console.ReadLine());

            p = l * la;

            Console.WriteLine("El perimetro es :" + p);

        }

        public static void Radianes()
        {
            double g, r;
            double pi = 3.1416;
            double ang = 180;
            Console.WriteLine("Ingresa el grado que desee calcular");
            g = Convert.ToInt16(Console.ReadLine());
            r = g * pi / ang;

            Console.WriteLine("El resultado es :" + r);
        }

        public static void dolareseuros()
        {
            int e, d, te, td;
            Console.WriteLine("Ingresa la cantidad de dolar a euro que desea calcular");
            d = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad de euro a dolar  que desea calcular");
            e = Convert.ToInt16(Console.ReadLine());

            te = d * 11875;
            td = e * 08421;

            Console.WriteLine("El resultado de su cambio a euros :" + te);

            Console.WriteLine("El resultado de su cambio a dolares :" + td);

        }

        public static void parimpar()
        {
            int N;
            Console.WriteLine("Ingrese el numero que desea calcular");
            N = Convert.ToInt16(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("Su numero es par:");
            }
            else
            {

                Console.WriteLine("Su numero no es par:");
            }

        }

        public static void semana() 
        {
            int d;
            Console.WriteLine("Ingrese un numero del 1 al 7");
            d = Convert.ToInt16(Console.ReadLine());

            if (d==1)
            {
                Console.WriteLine(" El dia es lunes:");
            }
            else if (d==2)
            {
                Console.WriteLine(" El dia es martes:");
            }
            else if(d==3)
            {
                Console.WriteLine(" El dia es miercoles:");
            }else if(d==4)
            {
                Console.WriteLine(" El dia es jueves:");
            }
            else if (d == 5) 
            {
                Console.WriteLine(" El dia es viernes:");
            }
            else if(d==6)
            {
                Console.WriteLine(" El dia es sabado:");
            }
            else if(d==7)
            {
                Console.WriteLine(" El dia es domingo:");
            }
        }
    }
}
