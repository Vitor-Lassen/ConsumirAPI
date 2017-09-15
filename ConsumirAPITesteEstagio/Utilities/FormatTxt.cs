using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumirAPITesteEstagio.Utilities
{
    class FormatTxt
    {
        public void somenteNum(TextBox txt)
        {
            txt.KeyPress += somenteNum;
        }
        private void somenteNum(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
