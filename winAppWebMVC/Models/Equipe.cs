using System.Collections.Generic;
using System.IO;
using winAppWebMVC.Interface;

namespace winAppWebMVC.Models
{
    public class Equipe : DataBase, IEquipe
    {
        public int idEquipe { get; set; }
        public string nome { get; set; }
        public string imagem { get; set; }

        private const string _path = "Database/equipe.csv";

        public Equipe()
        {
            criarPastaOuArquivo(_path);
        }

        private string preparar(Equipe e)
        {
            return $"{e.idEquipe};{e.nome};{e.imagem}";
        }

        public void salvar(Equipe novaequipe)
        {
            string[] equipe_texto = {preparar(novaequipe) };
            File.AppendAllLines(_path, equipe_texto);
        }

        public List<Equipe> lerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();

            string[] equipes = File.ReadAllLines(_path);

            foreach (string item in equipes)
            {
                string[] linhaEquipe = item.Split(';');
                Equipe equipe = new Equipe();
                equipe.idEquipe = int.Parse(linhaEquipe[0]);
                equipe.nome = linhaEquipe[1];
                equipe.imagem = linhaEquipe[2];

                listaEquipes.Add(equipe);

            }

            return listaEquipes;
        }
    }
}
