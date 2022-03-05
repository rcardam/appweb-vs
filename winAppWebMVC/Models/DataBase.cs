using System.IO;

namespace winAppWebMVC.Models
{
    public class DataBase
    {

        public void criarPastaOuArquivo(string _path)
        {

            string pasta = _path.Split('/')[0];

            int total = _path.Split('/').Length;

            string arquivo = _path.Split('/')[total-1];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(_path))
            {
                File.Create(_path).Close();
            }

        }
    }
}
