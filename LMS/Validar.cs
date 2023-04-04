using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    class Validar
    {

        public static void SoloLetras(KeyPressEventArgs pE)
        {
            //Para obligar a que sólo se introduzcan letras
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))//permitir teclas de control como retroceso
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))// no permite tecla de espacio
            {
                pE.Handled = true;
            }
            else if (Char.IsSymbol(pE.KeyChar))// no permite acentos
            {
                pE.Handled = true;
            }
            else //el resto de teclas pulsadas se desactivan
            {
                pE.Handled = true;
            }
        }
    }
}
