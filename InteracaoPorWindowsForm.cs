using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_dos_Animais.GUI
{
    public class InteracaoPorWindowsForm : IInteracaoComUsuario
    {
        bool IInteracaoComUsuario.interagir(string pergunta)
        {
            return DialogResult.Yes == this.mostrarPergunta(pergunta);
        }

        void IInteracaoComUsuario.mostraVitoria()
        {
            MessageBox.Show("Ganhei denovo.", "Caixa de Mensagens", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string IInteracaoComUsuario.aprender(string texto)
        {
            return new FrmAprende(texto).MostraForm();
        }

        public DialogResult mostrarPergunta(string pergunta)
        {
            return MessageBox.Show(pergunta + " ?", "Caixa de mensagens", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
