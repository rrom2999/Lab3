using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3.Models;
using Lab3.Entities;
namespace Lab3.Repository
{
    interface IFacturacion
    {
        void CrearFactura(ClienteViewModel cliente, List<CarritoEntity> carrito);
    }
}
