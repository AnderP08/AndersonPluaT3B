using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonPluaT3B.Insertar_10_instancias
{
    class Tarea2
    {
        // - Cliente(id: integer, Nombre: string)
        class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
        // - Factura(Observación: string, idcliente: integer, fecha: date, total: numeric)

        class Factura
        {
            public string Observacion { get; set; }
            public int IdCliente { get; set; }
            public System.DateTime fecha { get; set; }
            public int total { get; set; }
        }
        // - Insertar 10 instancias en cada una de las clases expuestas, luego realizar las siguientes consultas:
        // - Mostrar por consola:

        List<Cliente> clientes = new List<Cliente>()
            {
            new Cliente(){Id = 1, Nombre = "Ander"},
            new Cliente(){Id = 2 , Nombre = "Albet"},
            new Cliente(){Id = 3 , Nombre = "Diana"},
            new Cliente(){Id = 4 , Nombre = "Lupe"},
            new Cliente(){Id = 5 , Nombre = "Carlos"},
            new Cliente(){Id = 6 , Nombre = "Sara"},
            new Cliente(){Id = 7 , Nombre = "Susana"},
            new Cliente(){Id = 8 , Nombre = "Angie"},
            new Cliente(){Id = 9 , Nombre = "Belen"},
            new Cliente(){Id = 10 , Nombre = "Elsa"},
            };

        List<Factura> facturas = new List<Factura>()
            {
            new Factura(){Observacion = "Observa1", IdCliente = 1, fecha = new DateTime(2019,01,02), total = 110},
            new Factura(){Observacion = "Prob2", IdCliente = 2, fecha = new DateTime(2019,02,04), total = 220},
            new Factura(){Observacion = "Observa3", IdCliente = 3, fecha = new DateTime(2019,03,06), total = 330},
            new Factura(){Observacion = "Observa4", IdCliente = 4, fecha = new DateTime(2019,04,08), total = 440},
            new Factura(){Observacion = "Observa5", IdCliente = 5, fecha = new DateTime(2019,05,10), total = 550},
            new Factura(){Observacion = "Prob6", IdCliente = 6, fecha = new DateTime(2019,06,12), total = 660},
            new Factura(){Observacion = "Observa7", IdCliente = 7, fecha = new DateTime(2019,07,14), total = 770},
            new Factura(){Observacion = "Observa8", IdCliente = 8, fecha = new DateTime(2019,08,16), total = 880},
            new Factura(){Observacion = "Observa9", IdCliente = 9, fecha = new DateTime(2019,09,18), total = 990},
            new Factura(){Observacion = "Prob10", IdCliente = 10, fecha = new DateTime(2019,10,20), total = 1234},
            };


        public void ClienteFactura()
        {


            //  •	Los clients ordenados por nombre
            Console.WriteLine("Ordenados por nombre");
            var ClientOrdenados = from ordenado in clientes orderby ordenado.Nombre select ordenado;
            foreach (var item in ClientOrdenados)
            {
                Console.WriteLine(item.Nombre);
            }




            //  •	Las ventas ordenadas por fecha
            Console.WriteLine("Ordenados por fecha");
            var OrdenFecha = from oF in facturas orderby oF.fecha descending select oF;
            foreach (var item in OrdenFecha)
            {
                DateTime sfecha = item.fecha;   DateTime Fecha = sfecha.Date;
                Console.WriteLine("Fecha: " + Fecha.ToShortDateString() + " Venta: " + item.total);
            }




            //  •	Los 3 clientes con más monto en ventas.
            Console.WriteLine("3 clientes más monto en ventas");
            int mayorUno = 0;
            int mayorDos = 0;
            int mayorTres = 0;
            string primeMayor = "";
            string segundoMayor = "";
            string tercerMayor = "";
            foreach (var item in facturas)
            {
                if (item.total > mayorUno)
                {
                    mayorUno = item.total; primeMayor = item.Observacion;
                }
            }
            foreach (var item in facturas)
            {
                if (item.total > mayorDos && item.total != mayorUno)
                {
                    mayorDos = item.total; segundoMayor = item.Observacion;
                }
            }

            foreach (var item in facturas)
            {
                if (item.total > mayorTres && item.total != mayorUno && item.total != mayorDos)
                {
                    mayorTres = item.total; tercerMayor = item.Observacion;
                }
            }
            Console.WriteLine("primer" + primeMayor + " " + mayorUno + "  segundo " + segundoMayor + " " + mayorDos + "  tercero " + tercerMayor + " " + mayorTres);




            //  •	Los 3 clientes con menos monto en ventas.
            Console.WriteLine("3 clientes menos monto en ventas");
            int mayor = 0;
            int a = 0, b = 0, c = 0;
            int menorUno = 0;
            int menorDos = 0;
            int menorTres = 0;
            string primerMenor = "";
            string segundoMenor = "";
            string tercerMenor = "";
            foreach (var item in facturas)
            {
                if (item.total > mayor)
                {
                    mayor = item.total; a = item.total; b = item.total; c = item.total;
                }
            }
            foreach (var item in facturas)
            {
                if (item.total < a)
                {
                    a = item.total; menorUno = item.total; primerMenor = item.Observacion;
                }
            }
            foreach (var item in facturas)
            {
                if (item.total < b && item.total != menorUno)
                {
                    b = item.total; menorDos = item.total; segundoMenor = item.Observacion;
                }
            }
            foreach (var item in facturas)
            {
                if (item.total < c && item.total != menorUno && item.total != menorDos)
                {
                    c = item.total; menorTres = item.total; tercerMenor = item.Observacion;
                }
            }
            Console.WriteLine("primer"+ primerMenor +" "+ menorUno +"  segundo " + segundoMenor +" "+ menorDos + "  tercero " + tercerMenor +" "+ menorTres);




            //  •	El cliente con más ventas realizadas.
            Console.WriteLine("Cliente con más ventas realizadas");
            var Mayor = facturas.Max(i => i.total);
            Console.WriteLine(Mayor);




            //  •	El cliente y la cantidad de ventas realizadas.
            Console.WriteLine("Cliente y la cantidad de ventas realizadas.");
            var CVMayor = from cvm in facturas
           join cl in clientes on cvm.IdCliente equals cl.Id select new
            {
                Venta = cvm.total,
                Cliente = cl.Nombre
            };
            foreach (var item in CVMayor)
            {
                Console.WriteLine("{0}= {1}", item.Cliente, item.Venta);
            }




            //Cliente con las ventas realizadas menos de un año
            Console.WriteLine("\n{Cliente con la venta con menos de 1 año}");
            var fechamenosdeunaño = from m in listafactura
                                    join a in listacliente on m.IdCliente equals a.Id
                                    orderby m.Fecha
                                    select new { dcliente = a.Nombres, m.Fecha };
            DateTime fecha = DateTime.Today;
            foreach (var item in fechamenosdeunaño)
            {
                if (item.Fecha >= fecha)
                {
                    Console.WriteLine("{0} = {1}", item.Fecha, item.dcliente);
                }
            }



            //  •	Las ventas realizadas hace menos de 1 año.
            Console.WriteLine("Ventas realizadas hace menos de 1 año");




            //  •	La venta más antigua.
            Console.WriteLine("Venta más antigua");
            var r = from i in facturas select i;
            System.DateTime ssfecha = new DateTime(2019, 01, 01);

            var RangoFecha = from i in facturas where i.fecha >= ssfecha select i;

            //resultado = from i in facturas where i.fecha >= sfecha select i;
            foreach (var item in RangoFecha)
            {
                Console.WriteLine(item.fecha);
            }




            //  •	La última venta realizada.
            Console.WriteLine("Ultima venta realizada");



            //  •	Los clientes que tengan una venta cuya observación comience con "Prob".
            Console.WriteLine("Clientes que tengan una venta cuya observación comience con (Prob) ");





        }




    }
}
