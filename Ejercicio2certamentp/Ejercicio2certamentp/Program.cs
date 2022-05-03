using System;

namespace Ejercicio2certamentp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0, nummenor = 0, nummayor = 0, diferencia=nummayor-nummenor, dia = nummenor ;
            

            Console.WriteLine("Ingrese primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tercer numero");
            num3 = int.Parse(Console.ReadLine());

            nummayor = num1; nummenor = num1;
            

            if (num2 > nummayor)
            {
                nummayor = num2;
            }
            if (num3 > nummayor)
            {
                nummayor = num3;
            }
            if (num2 < nummenor)
            {
                nummenor = num2;
            }
            if (num3 < nummenor)
            {
                nummenor = num3;
            }          
                        
            Console.WriteLine("El numero menor es: " + nummenor);
            Console.WriteLine("El numero mayor es: " + nummayor);
            
            switch (diferencia)
            {
                case 1:
                    Console.WriteLine("el mes es Enero");
                    break;
                case 2:
                    Console.WriteLine("el mes es Febrero");
                    break;
                case 3:
                    Console.WriteLine("el mes es Marzo");
                    break;
                case 4:
                    Console.WriteLine("el mes es Abril");
                    break;
                case 5:
                    Console.WriteLine("el mes es Mayo");
                    break;
                case 6:
                    Console.WriteLine("el mes es Junio");
                    break;
                case 7:
                    Console.WriteLine("el mes es Julio");
                    break;
                case 8:
                    Console.WriteLine("el mes es Agosto");
                    break;
                case 9:
                    Console.WriteLine("el mes es Septiembre");
                    break;
                case 10:
                    Console.WriteLine("el mes es Octubre");
                    break;
                case 11:
                    Console.WriteLine("el mes es Noviembre");
                    break;
                case 12:
                    Console.WriteLine("el mes es Diciembre");
                    break;
            }
            switch (dia)
            {
                case 1:
                    Console.WriteLine("el dia es Lunes");
                    break;
                case 2:
                    Console.WriteLine("el dia es Martes");
                    break;
                case 3:
                    Console.WriteLine("el dia es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("el dia es Jueves");
                    break;
                case 5:
                    Console.WriteLine("el dia es Viernes");
                    break;
                case 6:
                    Console.WriteLine("el dia es Sabado");
                    break;
                case 7:
                    Console.WriteLine("el dia es Domingo");
                    break;
                
            }

            Console.WriteLine("numeros pares e impares entre A=menor y C= Mayor");
            Console.Write("Siendo el rango de numero menor y mayor: ");
           
            Console.WriteLine("\n\nLos numeros pares entre los numeros dados " + nummenor + " - " + nummayor + " son: \n");
            for (int i = nummenor; i <=nummayor; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " "); 
                }
            }
            Console.WriteLine("\n\nLos numeros impares entre los numeros dados " + nummenor + " - " + nummayor + " son: \n");
            for (int i = nummenor; i <= nummayor; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.Read();




        }
    }
}
