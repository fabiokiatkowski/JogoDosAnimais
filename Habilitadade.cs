using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_dos_Animais
{
    public class Habilitadade : Acao
    {
        private const string _PERGUNTA = "O animal que você pensou ";
        private Acao _respostaSim;
        private Acao _respostaNao;

        public Habilitadade(Acao respostaSim, Acao respostaNao, string caracteristica, GUI.IInteracaoComUsuario interacaoComUsuario) 
            : base(caracteristica, interacaoComUsuario)
        {
            this._respostaSim = respostaSim;
            this._respostaNao = respostaNao;
        }

        public override Acao Executar(Acao animal)
        {
            //Mostra a pergunta com a habilidade para tentar advinhar o animal
            //em caso qualquer das resposta, é aqui que acontece a mágia do jogo
            //ao atribuir o retorno o método Executar para _respostaSim e _respostaNao
            //o código substitui o nó de animal por um nó de habilidade, fazendo com
            //que o nó de animal se torne a resposta não do animal pensado.
            if (MostraPergunta(_PERGUNTA, this.Descricao))
                this._respostaSim = this._respostaSim.Executar(null);
            else
                this._respostaNao = this._respostaNao.Executar(null);

            return this;
        }
    }
}
