using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3.Models;
using System.IO;
using Lab3.Entities;

namespace Lab3.Repository
{
    public class Facturacion : IFacturacion
    {
        public void CrearFactura(ClienteViewModel cliente, List<CarritoEntity> carrito)
        {
            string archivo = "Factura_" + cliente.nombre + ".txt";
            StreamWriter writer = new StreamWriter(archivo);
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            //Depuración y dar formato a los datos
            //Linea 1
            CarritoEntity a = new CarritoEntity();           
            
            string Linea1 = "Nombre: " + cliente.nombre + " No. de Nit: " + cliente.nit + " Fecha: " + fecha;
            string datosCompra = "Cantidad / Nombre / descripción / Precio (c/u) / Total $.";
            writer.WriteLine("\t\t Tu salud en mis manos S.A.");
            writer.WriteLine(Linea1);
            writer.WriteLine("Dirección: " + cliente.direccion);
            writer.WriteLine(datosCompra);
            foreach (var item in carrito)
            {
                writer.Write(item.cantidad+" | "+ item.Nombre + " | " +item.Descripcion + " | $." +item.Precio + " | $." +item.total);
                writer.Write("\n");
            }
            writer.Write("Total $." + cliente.total);
            writer.Close();
        }
    }
}
