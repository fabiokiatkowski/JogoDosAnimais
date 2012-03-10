using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_dos_Animais
{
    public class AfirmaVitoria : Acao
    {
        public AfirmaVitoria(GUI.IInteracaoComUsuario interacaoComUsuario)
            : base("", interacaoComUsuario)
        {
        }
        
        public override Acao Executar(Acao animal)
        {
            this.INTERACAO_COM_USUARIO.mostraVitoria();
            return animal;
        }
    }
}
