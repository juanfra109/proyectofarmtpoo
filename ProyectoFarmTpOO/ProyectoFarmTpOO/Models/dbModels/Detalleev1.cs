using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFarmTpOO.Models.dbModels
{
    [Table("detalleev", Schema = "farmacia")]
    public partial class Detalleev1
    {
        [Key]
        [Column("Id_detalleEP")]
        public int IdDetalleEp { get; set; }
        [Column("Id_empl")]
        public int IdEmpl { get; set; }
        [Column("Id_prov")]
        public int IdProv { get; set; }
        [Column("fech_detalleEP", TypeName = "date")]
        public DateTime FechDetalleEp { get; set; }

        [ForeignKey("IdEmpl")]
        [InverseProperty("Detalleev1s")]
        public virtual Empleado IdEmplNavigation { get; set; } = null!;
        [ForeignKey("IdProv")]
        [InverseProperty("Detalleev1s")]
        public virtual Proveedor IdProvNavigation { get; set; } = null!;
    }
}
