using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_WEB.Models.Clients
{
    public class Cl_Has_Requisitos
    {
        [Key]
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public bool ContarAlarma { get; set; }
        public bool ContarAlarma_ { get; set; }
        public bool EquipoCovid { get; set; }
        public bool EquipoCovid_ { get; set; }
        public bool EquipoSeguridad { get; set; }
        public bool EquipoSeguridad_ { get; set; }
        public bool Instruccion { get; set; }
        public bool IntruccionDescarga { get; set; }
        public bool LlevarCertificado { get; set; }
        public bool LlevarCertificado_ { get; set; }
        public bool LlevarGatas { get; set; }
        public bool LlevarGatas_ { get; set; }
        public bool LlevarIne { get; set; }
        public bool LlevarIne_ { get; set; }
        public bool LlevarLicencia { get; set; }
        public bool LlevarLicencia_ { get; set; }
        public bool LlevarPoliza { get; set; }
        public bool LlevarPoliza_ { get; set; }
        public bool LlevarSua { get; set; }
        public bool LlevarSua_ { get; set; }
        public bool LlevarTarjeta { get; set; }
        public bool LlevarTarjeta_ { get; set; }
        public bool LlevarTodos_ { get; set; }
        public bool PresentarseMin_ { get; set; }
        public bool UnidadCondiciones { get; set; }
    }
}
