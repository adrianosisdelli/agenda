using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contador
    {
        private string nome;
        private IMonitor control;
        private int contagem;

        public Contador(string nome)
        {
            this.nome = nome;
            this.contagem = 0;
        }

        public void setMonitor(IMonitor monitor)
        {
            this.control = monitor;
        }

        public void ativar()
        {
            if (this.control != null)
            {
                this.control.atualizar(string.Format("{0} - {1}", this.contagem, this.nome));
                this.contagem++;
            }
        }
    }
}
