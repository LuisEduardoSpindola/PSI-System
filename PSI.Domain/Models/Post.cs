﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PSI.Domain.Models;

[Table("Post")]
public partial class Post
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Titulo { get; set; }

    [Unicode(false)]
    public string Descricao { get; set; }

    [Required]
    [StringLength(50)]
    public string Autor { get; set; }

    [Unicode(false)]
    public string Imagem { get; set; }

    [Column(TypeName = "date")]
    public DateTime Data { get; set; }

    public bool? Importancia { get; set; }
}