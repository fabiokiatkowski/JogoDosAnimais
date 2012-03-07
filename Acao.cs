using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_dos_Animais
{
    public abstract class Acao
    {
        public virtual void Executar() {}

        public DialogResult MostraPergunta(string pergunta, string carac)
        {
            return MessageBox.Show(pergunta + carac + "?", "", MessageBoxButtons.YesNo);
        }

        public bool IsPerguntaValida(DialogResult pergunta)
        {
            return pergunta == DialogResult.Yes;
        }
    }
}
