using System.Collections.Generic;
using winAppWebMVC.Models;

namespace winAppWebMVC.Interface
{
    public interface IEquipe
    {

        void salvar(Equipe novaequipe);

        List<Equipe> lerEquipes();
    }
}
