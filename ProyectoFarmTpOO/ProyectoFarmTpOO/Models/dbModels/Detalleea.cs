﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFarmTpOO.Models.dbModels
{
    [Table("detalleea", Schema = "farmacia")]
    public partial class Detalleea
    {
        [Key]
        [Column("id_detalleEA")]
        public int IdDetalleEa { get; set; }
        [Column("id_empl")]
        public int IdEmpl { get; set; }
        [Column("id_alm")]
        public int IdAlm { get; set; }
        [Column("fecha_detalleEA", TypeName = "date")]
        public DateTime FechaDetalleEa { get; set; }

        [ForeignKey("IdAlm")]
        [InverseProperty("Detalleeas")]
        public virtual Almacen IdAlmNavigation { get; set; } = null!;
    }
}
