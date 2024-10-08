﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioskoInformaticoServices.Models;

public partial class Producto
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; } = null!;

    [Required]
    [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]

    public decimal Precio { get; set; }

   
    public bool Eliminado { get; set; } = false;

    public bool oferta { get; set; } = false;
}

