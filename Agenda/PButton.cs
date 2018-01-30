using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public class PButton : Button
    {
        private int qtdeSolicitacoes = 0;
        private string nome = "Adriano Sisdelli Costa";

        public void alteraLabel(string novaLabel)
        {
            this.Text = novaLabel;
            this.qtdeSolicitacoes++;
        }
    }
}
