using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFarmTpOO.Models.dbModels
{
    [Table("venta", Schema = "farmacia")]
    public partial class Ventum
    {
        [Key]
        [Column("Id_vent")]
        public int IdVent { get; set; }
        [Column("Fech_vent", TypeName = "date")]
        public DateTime FechVent { get; set; }
        [Column("total_vent", TypeName = "decimal(19, 4)")]
        public decimal TotalVent { get; set; }
        [Column("Id_empl")]
        public int IdEmpl { get; set; }

        [ForeignKey("IdEmpl")]
        [InverseProperty("Venta")]
        public virtual Empleado IdEmplNavigation { get; set; } = null!;
        [InverseProperty("IdVentNavigation")]
        public virtual DetalleEv? DetalleEv { get; set; }
    }
}
