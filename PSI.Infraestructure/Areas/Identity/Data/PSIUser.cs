using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PSI.Infraestructure.Areas.Identity.Data;

// Add profile data for application users by adding properties to the PSIUser class
public class PSIUser : IdentityUser
{
    public string NomeUsuario { get; set; }
    public int PassCod{ get; set; }
    public int Periodo { get; set; }
}

