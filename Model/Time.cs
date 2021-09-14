using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjLux.Model
{
    public class Time
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Data { get; set; }
        List<Jogador> Jogadores { get; set; }
        public Time (string nome)
        {
            Nome = nome;
            Jogadores = new List<Jogador>();
        }
    }
}
