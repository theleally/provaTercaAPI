using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Automovel
    {
        // Construtor
        public Automovel() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public string Modelo { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() => 
        $"Marca: {Marca} | Modelo: {Modelo} | Criado em: {CriadoEm}";
    }
}