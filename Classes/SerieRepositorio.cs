using System;
using System.Collections.Generic;
using App_simple.Interfaces;

namespace App_simple
{
  public class SerieRepositorio : Irepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualiza(int id, Serie objeto)
    {
      listaSerie[id] = objeto;
    }
    public void Exclui(int id)
    {
      listaSerie[id].Excluir();
    }
    public void Insere(Serie entidade)
    {
      listaSerie.Add(objeto);
    }
    public List<Serie> Lista()
    {
      return listaSerie;
    }
    public int ProximoId()
    {
      return listaSerie.Count;
    }
    public Serie RetornaIr(int id)
    {
      return listaSerie[id];
    }
  }
}
