using KLS_WEB.Models.Carriers;
using KLS_WEB.Models.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KLS_WEB.Models.Travels
{
    public class Section
    {
        public int Id { get; set; }
        public int TravelId { get; set; }
        public Travel Travel { get; set; }
        public ICollection<Service> Services { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int SubstatusId { get; set; }
        public Substatus Substatus { get; set; }
        public string Folio { get; set; }
        public int ClientesId { get; set; }
        public Clientes Clients { get; set; }
        public int Cl_Has_OrigenId { get; set; }
        public Cl_Has_Origen Cl_Has_Origen { get; set; }
        public int Cl_Has_DestinosId { get; set; }
        public Cl_Has_Destinos Cl_Has_Destinos { get; set; }
        public int SectionTypeId { get; set; }
        public SectionType SectionType { get; set; }
        public int Cl_Has_OtrosId { get; set; }
        public Cl_Has_Otros Cl_Has_Otros { get; set; }
        public int RutaId { get; set; }
        public Ruta Ruta { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Anticipacion { get; set; }
        public string Espejo { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public decimal Alto { get; set; }
        public decimal Ancho { get; set; }
        public decimal Largo { get; set; }
        public decimal Peso { get; set; }
        public decimal PesoVolumetrico { get; set; }
        public bool IsEmpty { get; set; } = false;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; } = true;
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
