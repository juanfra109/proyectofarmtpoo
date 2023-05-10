using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFarmTpOO.Models.dbModels
{
    [Table("detalleap", Schema = "farmacia")]
    public partial class Detalleap
    {
        [Key]
        [Column("Id_detalleap")]
        public int IdDetalleap { get; set; }
        [Column("id_prod")]
        public int IdProd { get; set; }
        [Column("Id_alm")]
        public int IdAlm { get; set; }

        [ForeignKey("IdAlm")]
        [InverseProperty("Detalleaps")]
        public virtual Almacen IdAlmNavigation { get; set; } = null!;
    }
}
