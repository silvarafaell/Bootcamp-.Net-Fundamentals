using App.Series.Interfaces;
using System;
using System.Collections.Generic;

namespace App.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaserie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaserie[id] = objeto;
        }
        public void Exclui(int id)
        {
            listaserie[id].Exclui();
        }

        public void Insere(Serie objeto)
        {
            listaserie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaserie;
        }

        public int ProximoId()
        {
            return listaserie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaserie[id];
        }
    }
}