using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStima2
{
    class GrafAdj
    {
        private Dictionary<string,string> map = new Dictionary<string, string>();
        private int jmlh_sisi = 0;
        private int jmlh_simpul = 0;

        public Dictionary<string, string> getMap()
        {
            return map;
        }

        public void createMap(string[] lines)
        {
            map = new Dictionary<string, string>();
            jmlh_sisi = Int32.Parse(lines[0]);
            //proses tiap line, mulai dari indeks satu
            for (int i = 1; i < lines.Length; i++)
            {
                string temp;
                List<string> tempList = new List<string>();
                //split jadi dua simpul
                string[] substring = lines[i].Split(' ');
                string key = substring[0];
                string value = substring[1];
                //add ke graph (adjacency map)
                //cek sudah exists
                bool keyExists = map.TryGetValue(key, out temp);
                if(keyExists)
                {
                    tempList.Add(temp);
                    tempList.Add(value);
                    string[] tempArr = tempList.ToArray();
                    value = string.Join(" ", tempArr);
                    //debug
                    Console.WriteLine("Value: "+value);
                    map[key] = value;
                }
                else
                {
                    //debug
                    Console.WriteLine("Value: "+value);
                    map.Add(key, value);
                    //tambah simpul
                    jmlh_simpul++;
                }   
            }
            //debug line
            foreach (var pair in map)
            {
                Console.WriteLine("Simpul = {0}, Tetangga = {1}", pair.Key, pair.Value);
            }
        }
        public int getJmlhSisi()
        {
            return jmlh_sisi;
        }
        public int getJmlhSimpul()
        {
            return jmlh_simpul;
        }
        public string[] getDaftarSimpul()
        {
            List<string> tempList = new List<string>();
            foreach (var pair in map)
            {
                tempList.Add(pair.Key);
            }
            return tempList.ToArray();
        }
    }
}
