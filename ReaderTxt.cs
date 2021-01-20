using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class ReaderTxt
{
     private string _path;
    public ReaderTxt(string path){
        _path = path;
    }

    public List<ITerrain> LoadFile() 
    {
        List<ITerrain> terrains = new List<ITerrain>();
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
                int valueSale = Int32.Parse(lineArray[0].Trim());
                int valueRent = Int32.Parse(lineArray[1].Trim());
                Terrain terrain = new Terrain(valueSale, valueRent);
                terrains.Add(terrain);
            }
            file.Close();
        }
        return terrains;
    }
}