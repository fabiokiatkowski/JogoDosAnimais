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
        private Aprende _aprendeAquatico;
        private string _nomeAnimal;

        public Animal(Aprende aprendeAquatico, string nomeAnimal)
        {
            // TODO: Complete member initialization
            this._aprendeAquatico = aprendeAquatico;
            this._nomeAnimal = nomeAnimal;
        }

        public override void Executar()
        {
            if (IsPerguntaValida(MostraPergunta(_PERGUNTA, this._nomeAnimal)))
                MessageBox.Show("Ganhei denovo.");
            else
                _aprendeAquatico.Executar();
        }
    }
}
