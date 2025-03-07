﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webAPI.Domains
{
    public partial class ClassesHabilidade
    {
        public int IdClasseHab { get; set; }
        public int? IdClasse { get; set; }
        public int? IdHabilidade { get; set; }

        public virtual Classe IdClasseNavigation { get; set; }
        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
