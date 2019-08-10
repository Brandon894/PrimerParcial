using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Nomre del Alumno : BRANDON ESTUARDO MENESES OBREGÓN");
            Console.WriteLine();
            Console.WriteLine("                   EMPRESA LOS MARA                ");

            cliente persona1 = new cliente("143265987", "Alberto Rodolfo", " Mendez Sosa ", " 9564464333-9", " Colonia San Andres ", "12345679", " Claudia Ramirez ", "", 850);
            persona1.persona();

            cliente persona2 = new cliente("964624664", " Mario Luke ", " Cantinero Lucas ", " 356466856-8", " Canton Diaz Cajas ", "9865472326", " Luis Gonzalez ", "", 3000);
            persona2.persona();

            cliente persona3 = new cliente("143265987", "Marcos Ulises ", " Lopez Mar ", " 564255466_-3", " Zona 5 ", "97563012", " Mario Tupul ", "", 6000);
            persona3.persona();
        }
        public class cliente
        {
                public cliente (string codigo, string nombres, string apellidos, string nit, string direccion, string telefono,string servidor, string tipodecliente, decimal totaldecompras)
            {
                this.codigo = codigo;
                this.nombres = nombres;
                this.apellidos = apellidos;
                this.nit = nit;
                this.direccion = direccion;
                this.telefono = telefono;
                this.servidor = servidor;
                this.tipodecliente = tipodecliente;
                this.totaldecompras = totaldecompras;

               if (totaldecompras <= 1500)
                {
                    this.tipodecliente = " Cliente Normal ";
                }
                else if (totaldecompras >= 1501 && totaldecompras <= 5000)
                {
                    this.tipodecliente = " Cliente Especial ";
                }
               else if (totaldecompras >= 5001 )
                {
                    this.tipodecliente = " Cliente Mayorista ";
                }
            }

            public string codigo { get; set; }
            public string nombres { get; set; }
            public string apellidos { get; set; }
            public string nit { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
            public string servidor { get; set; }
            public string tipodecliente { get; set; }
            public decimal  totaldecompras { get; set; }

            public void persona()
            {
                Console.WriteLine();
               Console.WriteLine(" Codigo de cliente: "+this.codigo+" Nombre del Cliente "+ this.nombres+ " Apellidos: "+this.apellidos+ " Nit: "+this.nit+ " Direccion: "+this.direccion+" Telefono: "+this.telefono+ "Nombre del vendedor: "+this.servidor+ " Tipo de Cliente: "+this.tipodecliente+ " Total de compras: "+this.totaldecompras );
                Console.ReadKey();
            }
        }
    }
    }

