using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo_dos_Animais
{
    public class Aprende : Acao
    {
        private GUI.IInteracaoComUsuario interacaoComUsuario;

        public Aprende(GUI.IInteracaoComUsuario interacaoComUsuario)
            :base("", interacaoComUsuario)
        {
            // TODO: Complete member initialization
            this.interacaoComUsuario = interacaoComUsuario;
        }
        
        public override Acao Executar(Acao animalAntigo)
        {
            string animal = this.INTERACAO_COM_USUARIO.aprender("Qual animal você pensou?");
            string habilidade = this.INTERACAO_COM_USUARIO.aprender("O que um(uma) " + animal + " faz que o " + animalAntigo.Descricao + " não?");

            return criaNovaHabilidadeComAnimais(animalAntigo, animal, habilidade);
        }

        private Habilitadade criaNovaHabilidadeComAnimais(Acao animalAntigo, string animal, string habilidade)
        {
            Animal novoAnimal = new Animal(new AfirmaVitoria(this.INTERACAO_COM_USUARIO), this, animal, this.INTERACAO_COM_USUARIO);
            return new Habilitadade(novoAnimal, animalAntigo, habilidade, this.INTERACAO_COM_USUARIO);
        }
    }
}
