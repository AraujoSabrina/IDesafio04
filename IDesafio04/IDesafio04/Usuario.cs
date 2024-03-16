using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDesafio04
{

    public class Usuario
    {
        public int Id { get; private set; }
        public Usuario(int id) {
            this.Id = id;
        }
      
       public int getId() { 
            return this.Id;
       }
    }
}
