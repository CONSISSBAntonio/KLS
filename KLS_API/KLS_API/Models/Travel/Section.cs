using KLS_API.Models.Carriers;
using KLS_API.Models.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Models.Travel
{
    public class Section
    {
        public int Id { get; set; }
        [Required]
        public int TravelId { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public int SubstatusId { get; set; }
        public virtual Substatus Substatus { get; set; }
        public string Folio { get; set; }
        public int? ClientesId { get; set; }
        public virtual Clientes Clients { get; set; }
        public int? Cl_Has_OrigenId { get; set; }
        public virtual Cl_Has_Origen Cl_Has_Origen { get; set; }
        public int? Cl_Has_DestinosId { get; set; }
        public virtual Cl_Has_Destinos Cl_Has_Destinos { get; set; }
        public int SectionTypeId { get; set; }
        public virtual SectionType SectionType { get; set; }
        public int? Cl_Has_OtrosId { get; set; }
        public virtual Cl_Has_Otros Cl_Has_Otros { get; set; }
        [Required]
        public int RutaId { get; set; }
        public virtual Ruta Ruta { get; set; }
        [Required]
        public DateTime FechaSalida { get; set; }
        [Required]
        public DateTime FechaLlegada { get; set; }
        public string Anticipacion { get; set; }
        public string Espejo { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Alto { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Ancho { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Largo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Peso { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PesoVolumetrico { get; set; }
        public bool IsEmpty { get; set; } = false;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; } = true;
        public DateTime TimeCreated { get; set; } = DateTime.Now;
        public DateTime TimeUpdated { get; set; }
    }
}
