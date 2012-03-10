using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_dos_Animais
{
    public class Animal : Acao
    {
        private const string _PERGUNTA = "O animal que você pensou foi ";
        private Acao afirmaVitoria;
        private Acao aprende;

        public Animal(AfirmaVitoria afirmaVitoria, Aprende aprende, string descricao, GUI.IInteracaoComUsuario interacaoComUsuario)
            : base (descricao, interacaoComUsuario)
        {
            this.afirmaVitoria = afirmaVitoria;
            this.aprende = aprende;
        }

        public override Acao Executar(Acao habilidade)
        {
            if (MostraPergunta(_PERGUNTA, this.Descricao))
                return this.afirmaVitoria.Executar(this);
            else
                return this.aprende.Executar(this);
        }
    }
}
