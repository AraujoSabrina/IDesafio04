using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDesafio04
{
  
        public class Banco
        {
            List<Usuario> Usuario = new List<Usuario>();


        

        public void adicionarUsuario(Usuario puser)
            {

                Usuario.Add(puser);    
            }
       



        public double depositar(int id, double deposito)
            {
            for (int i = 0; i < Usuario.Count; i++)
            {

                if (id == Usuario[i].getId())
                {

                    this.Usuario[i].saldo += deposito;
                    return Usuario[i].saldo;

                }
            }
            return 0;
                
            }
            public double getConta(int id)
            {
                for (int i = 0; i < Usuario.Count; i++)
                {
                    if (id == Usuario[i].getId())
                        return Usuario[i].saldo;
                }
                return 0;
            }
            public double sacar(int id, double saque)
            {
                for (int i = 0; i < Usuario.Count; i++)
                {
                if (id == Usuario[i].getId())
                {
                    if (saque <= Usuario[i].saldo)
                    {
                        this.Usuario[i].saldo -= saque;
                        return this.Usuario[i].saldo;
                    }
                    else
                    {
                        Console.WriteLine("Pobre");
                    }
                    
                    
                }

                }
                return 0;
            }

        }

    
}
