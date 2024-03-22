using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1
{
    public class alfaTotalDiario
    {
        public DateTime data {get; set;}
        public float valorAlfaD {get; set;};
        public HashSet<alfa> alfas {get; set;}

        public alfaTotalDiario(DateTime data, float valorAlfaD){
            this.data = data;
            this.valorAlfaD = valorAlfaD;
            this.alfas = new HashSet<alfa>();
        }

        public bool Validate(){
            if (alfas.Count == 0)
                return false;

            return valorAlfaD > 0;
        }    

        // OCL: context alfaTotalDiario
        // inv: alfas->size() > 0 implies valorAlfaD > 0 
    }
}