using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pveiculo;

namespace Pveiculo
{
    public class Veiculo
    {  
        public Veiculo(int id, decimal km, string tipoVeiculo, decimal velocidade, string cor) 
        {
            this.Id = id;
            this.Km = km;
            this.TipoVeiculo = tipoVeiculo;
            this.Velocidade= velocidade;
            this.Cor=cor;
        }      
        public int Id {get; set;}
        public string Cor {get; set;}
        public decimal Km {get; set;}
        public decimal Velocidade {get; set;}
        public string TipoVeiculo {get; set;}
      
         public void entrada()
        {
           Console.WriteLine($"Entrei Veiculo Id: {Id}");
            Console.WriteLine($"Entrei Veiculo KM: {Km}");
            Console.WriteLine($"Entrei Veiculo do Tipo: {TipoVeiculo}");
            Console.WriteLine($"Entrei Veiculo do Tipo: {Cor}");
            Console.WriteLine($"Entrei Veiculo com Velocidade: {Velocidade}");
            Console.WriteLine("");
            
        }
    } 
   
}