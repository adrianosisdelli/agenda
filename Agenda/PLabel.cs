using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public class PLabel : Label, IMonitor
    {
        public void atualizar(string valor)
        {
            this.Text = valor;
        }
    }
}
