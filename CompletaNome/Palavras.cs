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

        public Palavras()
        {
            palavra = "vermelho";
            palavra = palavra.ToUpper();
            this.caracterRemovido = palavra[new Random().Next(palavra.Length)];
        }
        
        public string getPalavra()
        {
            return palavra;
        }

        public char getCaracterRemovido()
        {
            return this.caracterRemovido;
        }

        public int numCaracter()
        {
            return getPalavra().Length;
        }

        public string retornaCaracter(int posicao)
        {
            return palavra[posicao].ToString();
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

        public string palavraIncompleta()
        {
            return palavra.Replace(getCaracterRemovido(), '_');
        }
    }
}
