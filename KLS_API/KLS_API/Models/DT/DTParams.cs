using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.DT
{
    public class DTParams
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public List<Column> columns { get; set; }
        public Search search { get; set; }
        public List<Order> order { get; set; }
        public SearchModel searchmodel { get; set; }
        public int[] Filter { get; set; } = new int[] { };
        public int SubstatusId { get; set; }
        public string CSType { get; set; }

        public class Column
        {
            public string data { get; set; }
            public string name { get; set; }
            public bool searchable { get; set; }
            public bool orderable { get; set; }
            public Search search { get; set; }
        }

        public class Search
        {
            public string[] value { get; set; }
            public string[] regex { get; set; }
        }

        public class Order
        {
            public int[] column { get; set; }
            public string[] dir { get; set; }
        }
        public bool CustomSearch { get; set; }
        public class SearchModel
        {
            public int ClientId { get; set; }
            public int UnitId { get; set; }
            public DateTime FechaSalida { get; set; }
            public int Rango { get; set; }
            public int EstadoOrigenId { get; set; }
            public int CiudadOrigenId { get; set; }
            public int EstadoDestinoId { get; set; }
            public int CiudadDestinoId { get; set; }
            public string TamañoEmpresa { get; set; }
            public int[] FiltroCliente { get; set; }
        }
    }
}
