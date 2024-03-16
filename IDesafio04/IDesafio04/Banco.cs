using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace IDesafio04
{
    public class Banco
    {
        List<Usuario> usario = new List<Usuario>();
        public void adicionarUsuario(Usuario user)
        {
            usario.Add(user);
        }
       

        public double depositar(int id, int deposito)
        {
           for (int i = 0; i < usario.Count; i++)
            {
                if (id == usario[i].getId())
                this.Valor += deposito;


            }

            return Valor;
        }
        public double Valor { get; private set; } = 200;
        public double getConta(int id)
        {
            for (int i = 0; i < usario.Count; i++)
            {
                if (id == usario[i].getId())
                    return this.Valor;
            }
            return 0;
        }
        public double sacar(int id, int saque)
        {
            for (int i = 0; i < usario.Count; i++)
            {
                if (id == usario[i].getId())
                    this.Valor -= saque;
                    return this.Valor;

            }
            return 0;
        }

    }

}
