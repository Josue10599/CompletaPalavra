using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompletaNome
{
    public  class Validate
    {
        public  bool ValidaVazio(TextBox textbox , ErrorProvider erroprovider) {


            if (String.IsNullOrWhiteSpace(textbox.Text) || textbox.TextLength > 30)
            {
                //setando o error provider passando so dois parametors necessarios, o controle(textbox) e a mensagem ("preencha...")
                erroprovider.SetError(textbox, "Preencha os campos em branco");
                return false;
            }
            else {

                erroprovider.SetError(textbox, "");
                return true;


            }


        }


        









    }
}
