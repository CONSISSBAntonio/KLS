using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travels
{
    public class CartaPorteModel
    {
        public string FolioFacturacion { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public string Ruta { get; set; }
        public string Ejecutivo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string PlazoEntrega { get; set; }
        public int Cantidad { get; set; }
        public string Embalaje { get; set; }
        public string Descripcion { get; set; }
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }
        public decimal ValorDeclarado { get; set; }
        public string DescripcionServicio { get; set; }
        public List<TransportistaModel> Transportistas { get; set; }
        public List<UnidadModel> Unidades { get; set; }
        public DateTime CitaCarga { get; set; }
        public DateTime CitaDescarga { get; set; }
        public string PolizaSeguro { get; set; }
        public string Maniobras { get; set; }
        public decimal Subtotal { get; set; }
        public string Kilometraje { get; set; }
        public string EmbalajeDos { get; set; }
        public decimal Iva { get; set; }
        public string Flete { get; set; }
        public string Otros { get; set; }
        public decimal Total { get; set; }
        public string OtrosRequisitos { get; set; }

        public class TransportistaModel
        {
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Pedido { get; set; }
        }
        public class UnidadModel
        {
            public string Nombre { get; set; }
            public string Placas { get; set; }
            public string Operador { get; set; }
        }
    }
}
