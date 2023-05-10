using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFarmTpOO.Models.dbModels
{
    [Table("almacen", Schema = "farmacia")]
    public partial class Almacen
    {
        public Almacen()
        {
            Detalleaps = new HashSet<Detalleap>();
            Detalleeas = new HashSet<Detalleea>();
        }

        [Key]
        [Column("Id_alm")]
        public int IdAlm { get; set; }
        [Column("nom_alm")]
        [StringLength(60)]
        public string NomAlm { get; set; } = null!;

        [InverseProperty("IdAlmNavigation")]
        public virtual ICollection<Detalleap> Detalleaps { get; set; }
        [InverseProperty("IdAlmNavigation")]
        public virtual ICollection<Detalleea> Detalleeas { get; set; }
    }
}
