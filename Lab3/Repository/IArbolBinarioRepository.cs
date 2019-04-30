using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab3.ArbolBinarioUtils;
using Lab3.Entities;

namespace Lab3.Repository
{
    public interface IArbolBinarioRepository
    {
        void LoadFile();
        FarmacoEntity ObtenerFarmaco(int linea);
        List<FarmacoEntity> BuscarFarmacos(string valor, int numeroDePagina, int noElementos);
        List<FarmacoEntity> Recorrer(int valor);
        List<FarmacoEntity> Buscar(string valor);
        void Modificar(string valor, int cantidad);
        void Simulacion(List<FarmacoEntity> a);
        string Total_compra(List<CarritoEntity> carritoDeCompras);
        
    }
}
