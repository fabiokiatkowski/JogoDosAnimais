using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_dos_Animais
{
    public abstract class Acao
    {
        private string _descricao;
        private GUI.IInteracaoComUsuario _interacaoComUsuario;

        public GUI.IInteracaoComUsuario INTERACAO_COM_USUARIO
        {
            get
            {
                return this._interacaoComUsuario;
            }
        }
        
        public Acao(string descricao, GUI.IInteracaoComUsuario interacaoComUsuario)
        {
            _descricao = descricao;
            this._interacaoComUsuario = interacaoComUsuario;
        }
        
        public abstract Acao Executar(Acao acao);

        public bool MostraPergunta(string pergunta, string carac)
        {
            return INTERACAO_COM_USUARIO.interagir(pergunta + carac);
        }

        public bool IsPerguntaValida(DialogResult pergunta)
        {
            return pergunta == DialogResult.Yes;
        }

        public string Descricao
        {
            get { return this._descricao; }
        }
    }
}
