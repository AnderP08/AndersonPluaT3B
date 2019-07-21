using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonPluaT3B.Lista_con_50_números_aleatorios
{
    class Tarea1
    {
            //Generar una lista con 50 números aleatorios. Con esta lista resolver los siguientes problemas:
            Console.WriteLine("Números Aleatorios");
            Random azar = new Random();
            List<int> NumerosAleatorios = new List<int>();

            for (int i = 0; i< 10; i++)
            {
                NumerosAleatorios.Add(azar.Next(15, 65));
            }
            NumerosAleatorios.ForEach(number => Console.WriteLine(number));




            //  •	Mostrar en consola todos los números primos.
            Console.WriteLine("{Numeros Primos}");
            var NumPrimo = from a in NumerosAleatorios select a;
            foreach (var item in NumPrimo)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }




            //  •	Mostrar en consola la suma de todos los elementos.
            Console.WriteLine("Suma de todos los elementos");
            var SumaElementos = NumerosAleatorios.Sum();
            Console.WriteLine(suma);




            //  •	Generar una nueva lista con el cuadrado de los números.
            Console.WriteLine("Lista con el cuadrado de los números");
            int CNum = 0;
            var CuadradoNum = from a in NumerosAleatorios where a >= 0 select a;
            foreach (var item in CuadradoNum)
            {
                CNum = item* item;
            Console.WriteLine(CNum);
            }




            //  •	Generar una nueva lista con los números primos.
            Console.WriteLine("Lista con numeros primos");
            List<int> NumPrimos = new List<int>();
            var Numpri = from np in NumerosAleatorios select np;
            foreach (var item in Numpri)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }




            //  •	Optener el promedio de todos los números mayores a 50.
            Console.WriteLine("Promedio números mayores a 50");
            int co = 0, di = 0, can = 0;
            var PromedioNum = from NumM in NumerosAleatorios where NumM >= 50 select NumM;
            foreach (var item in PromedioNum)
            {
                Console.WriteLine(item);
                co = co + item;
                can++;
            }
            di = co / can;
            Console.WriteLine("promedio");
            Console.WriteLine(di);




            //  •	Contar la cantidad de números pares e impares. Este problema debe resolverse en una única sentencia o en un solo querie.
            Console.WriteLine("Numeros pares e impares");
            int CP = 0, CI = 0;
            var ParesImpares = from paresimp in NumerosAleatorios select paresimp;
            Console.WriteLine("Los numeros impres son");
            foreach (var item in ParesImpares)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                    CI++;
                }
            }
            Console.WriteLine("Números impares:");
            Console.WriteLine(CI);
            Console.WriteLine("Números pares");
            foreach (var item2 in ParesImpares)
            {
                if (item2 % 2 == 0)
                {
                    Console.WriteLine(item2);
                    CP++;
                }
            }
            Console.WriteLine("La cantidad de numero pares son:");
            Console.WriteLine(CP);




            //  •	Mostrar en consola, el número y la cantidad de veces que este se encuentra en la lista.




            //  •	Mostrar en consola los elementos de forma descendente.
            Console.WriteLine("Desendentes");
            var NumDescendentes = from NumD in NumerosAleatorios orderby NumD descending select NumD;
            foreach (var item in NumDescendentes)
            {
                Console.WriteLine(item);
            }




            //  •	Mostrar en consola los número unicos.
            Console.WriteLine("Números unicos");
            int contador = 0;
            var NumUni = from U in NumerosAleatorios select U;
            foreach (var item in NumUni)
            {
                foreach (var item2 in NumUni)
                {
                    if (item == item2)
                    {
                        //cont++;
                    }
                    else
                    {
                        if (contador< 1)
                        {
                            contador++;
                        }
                    }
                    contador = 0;
                }
                Console.WriteLine(item);
            }




            //  •	Sumar todos los números unicos de la lista.
            int contadorUnicos;
            List<int> lista_unicos = new List<int>();
            for (int i = 0; i<NumerosAleatorios.Count; i++)
            {
                if (!(lista_unicos.Contains(NumerosAleatorios[i])))
                {
                    lista_unicos.Add(NumerosAleatorios[i]);
                }
            }
            foreach (var item in lista_unicos)
            {
                contadorUnicos = contadorUnicos + item;
            }
            Console.WriteLine("La Suma de los numeros unicos es = " + contadorUnicos);

    }
   }
}
