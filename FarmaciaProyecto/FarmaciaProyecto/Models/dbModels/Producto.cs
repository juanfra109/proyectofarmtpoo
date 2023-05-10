using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FarmaciaProyecto.Models.dbModels
{
    [Table("productos", Schema = "farmacia")]
    public partial class Producto
    {
        public Producto()
        {
            Carritos = new HashSet<Carrito>();
            Detallepps = new HashSet<Detallepp>();
        }

        [Key]
        [Column("Id_prod")]
        public int IdProd { get; set; }
        [Column("nom_prod")]
        [StringLength(50)]
        public string NomProd { get; set; } = null!;
        [Column("prec_prod")]
        public int PrecProd { get; set; }
        [Column("cant_prod")]
        public int CantProd { get; set; }

        [InverseProperty("IdProdNavigation")]
        public virtual ICollection<Carrito> Carritos { get; set; }
        [InverseProperty("IdProdNavigation")]
        public virtual ICollection<Detallepp> Detallepps { get; set; }
    }
}
