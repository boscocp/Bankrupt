using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class LeitorTxt
{
     private string _path;
    public LeitorTxt(string path){
        _path = path;
    }

    public List<ITerreno> CarregarArquivo() 
    {
        List<ITerreno> terrenos = new List<ITerreno>();
        using (StreamReader file = new StreamReader(_path))
        {
            while (file.Peek()>=0)
            {
                string line;
                string[] lineArray;
                line = file.ReadLine();
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                line = regex.Replace(line, " ");
                lineArray = line.Split(' ');
                int valorVenda = Int32.Parse(lineArray[0].Trim());
                int valorAluguel = Int32.Parse(lineArray[1].Trim());
                Terreno terreno = new Terreno(valorVenda, valorAluguel);
                terrenos.Add(terreno);
            }
            file.Close();
        }
        return terrenos;
    }
}