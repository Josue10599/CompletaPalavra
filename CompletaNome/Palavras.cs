using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletaNome
{
    class Palavras
    {
        private int idPalavra;
        private string palavra;
        private char caracterRemovido;
        private Banco banco;

        public string Palavra { get => palavra; set => palavra = value; }
        public int IdPalavra { get => idPalavra; set => idPalavra = value; }
        public char CaracterRemovido { get => caracterRemovido; set => caracterRemovido = value; }
        public Banco Banco { get => banco; }

        public Palavras()
        {
            IdPalavra = 1;
            banco = new Banco("localhost", "3306", "bancopal", "root", "", "banpal");
            if (!pegaPalavra(IdPalavra).Equals(""))
                removeCaracter(palavra);
        }

        public string pegaPalavra(int idPalavra)
        {
            if (idPalavra > 0)
            {
                Palavra = banco.SourceWord(idPalavra.ToString()).ToUpper();
                return Palavra;
            }
            else
            {
                return "";
            }
        }

        public void proximaPalavra()
        {
            IdPalavra++;
            if (!pegaPalavra(IdPalavra).Equals(""))
                removeCaracter(Palavra);
        }

        private void removeCaracter(string palavra)
        {
            do
                CaracterRemovido = palavra[new Random().Next(palavra.Length)];
            while (CaracterRemovido.ToString().Equals(" ") && CaracterRemovido.ToString().Equals("") 
            && CaracterRemovido.ToString().Equals("-") && CaracterRemovido.ToString().Equals("_"));                         
        }

        public int numCaracter()
        {
            return Palavra.Length;
        }

        public string palavraIncompleta()
        {
            return palavra.Replace(CaracterRemovido, '_');
        }

        public string retornaCaracter(int posicao)
        {
            return Palavra[posicao].ToString();
        }

        public ArrayList retornaCaracter()
        {
            ArrayList caracter = new ArrayList();
            for(int i = 0; i < palavra.Length; i++)
            {
                if (!caracter.Contains(palavra[i]))
                    caracter.Add(palavra[i]);
            }
            return caracter;
        } 

    }
}
