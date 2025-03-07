﻿using senai.hroads.webAPI.Contexts;
using senai.hroads.webAPI.Domains;
using senai.hroads.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webAPI.Repositories
{
    public class ClassesHabRepository : IClassesHabRepository
    {
        HROADSContext ctx = new HROADSContext();

        public void Atualizar(int idClasseHab, ClassesHabilidade classeHabAtualizada)
        {
            ClassesHabilidade classeHabBuscada = BuscarPorId(idClasseHab);

            if (classeHabAtualizada.IdClasse != null || classeHabAtualizada.IdHabilidade !=null)
            {
                classeHabBuscada.IdClasse = classeHabAtualizada.IdClasse;
                classeHabBuscada.IdHabilidade = classeHabAtualizada.IdHabilidade;
            }

            ctx.ClassesHabilidades.Update(classeHabBuscada);

            ctx.SaveChanges();
        }

        public ClassesHabilidade BuscarPorId(int idClasseHab)
        {
            return ctx.ClassesHabilidades.FirstOrDefault(ch => ch.IdClasseHab == idClasseHab);
        }

        public void Cadastrar(ClassesHabilidade novaClasseHab)
        {
            ctx.ClassesHabilidades.Add(novaClasseHab);

            ctx.SaveChanges();
        }

        public void Deletar(int idClasseHab)
        {
            ClassesHabilidade classeHabBuscada = BuscarPorId(idClasseHab);

            ctx.ClassesHabilidades.Remove(classeHabBuscada);

            ctx.SaveChanges();
        }

        public List<ClassesHabilidade> Listar()
        {
            return ctx.ClassesHabilidades.OrderBy(ch => ch.IdClasseHab).ToList();
        }
    }
}
