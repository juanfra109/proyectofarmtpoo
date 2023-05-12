using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProyectoTallerPOO.Models.dbModels;

[Table("empleado", Schema = "farmacia")]
[Index("TurnEmpl", Name = "IX_empleado_turn_empl")]
public partial class Empleado
{
    [Key]
    [Column("Id_empl")]
    public int IdEmpl { get; set; }

    [Column("nom_empl")]
    [StringLength(50)]
    [Unicode(false)]
    public string NomEmpl { get; set; } = null!;

    [Column("tel_emp")]
    [StringLength(50)]
    [Unicode(false)]
    public string TelEmp { get; set; } = null!;

    [Column("RFC_empl")]
    [StringLength(50)]
    [Unicode(false)]
    public string RfcEmpl { get; set; } = null!;

    [Column("dir_empl")]
    [StringLength(50)]
    [Unicode(false)]
    public string DirEmpl { get; set; } = null!;

    [Column("turn_empl")]
    public int TurnEmpl { get; set; }

    [Column("contraseña")]
    [StringLength(50)]
    [Unicode(false)]
    public string Contraseña { get; set; } = null!;

    [Column("correo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Correo { get; set; } = null!;

    [InverseProperty("IdEmplNavigation")]
    public virtual ICollection<Carrito> Carritos { get; set; } = new List<Carrito>();

    [InverseProperty("IdEmplNavigation")]
    public virtual ICollection<Detalleea> Detalleeas { get; set; } = new List<Detalleea>();

    [InverseProperty("IdEmplNavigation")]
    public virtual ICollection<Detalleev1> Detalleev1s { get; set; } = new List<Detalleev1>();

    [ForeignKey("TurnEmpl")]
    [InverseProperty("Empleados")]
    public virtual Turno TurnEmplNavigation { get; set; } = null!;

    [InverseProperty("IdEmplNavigation")]
    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
