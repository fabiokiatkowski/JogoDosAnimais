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
        private Animal _animalAquatico;
        private Animal _animalTerrestre;
        private string _caracteristica;

        public Habilitadade(Animal animalAquatico, Animal animalTerrestre, string caracteristica)
        {
            // TODO: Complete member initialization
            this._animalAquatico = animalAquatico;
            this._animalTerrestre = animalTerrestre;
            this._caracteristica = caracteristica;
        }

        public override void Executar()
        {
            if (IsPerguntaValida(MostraPergunta(_PERGUNTA, this._caracteristica)))
                this._animalAquatico.Executar();
            else
                this._animalTerrestre.Executar();
        }
    }
}
