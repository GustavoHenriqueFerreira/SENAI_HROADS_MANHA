﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webAPI.Domains
{
    public partial class TiposHabilidade
    {
        public TiposHabilidade()
        {
            Habilidades = new HashSet<Habilidade>();
        }

        public int IdTipoHab { get; set; }
        public string NomeTipoHab { get; set; }

        public virtual ICollection<Habilidade> Habilidades { get; set; }
    }
}
