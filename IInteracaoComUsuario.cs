using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo_dos_Animais.GUI
{
    public interface IInteracaoComUsuario
    {
        bool interagir(string pergunta);
        void mostraVitoria();
        string aprender(string texto);
    }
}
