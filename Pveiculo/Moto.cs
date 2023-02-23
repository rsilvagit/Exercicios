using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pveiculo
{
    public class Moto : Veiculo
    {
            public bool Bau {get; set;}
            public bool AntenaLinhaPipa {get; set;}
            public bool CapaChuva {get; set;} 
    public Moto (bool bau, bool capaChuva, bool antenaLinhaPipa,int id, decimal km, string tipoVeiculo, decimal velocidade,string cor) : base(id,km,tipoVeiculo,velocidade,cor)
        {
            this.Bau = bau;
            this.CapaChuva = capaChuva;
            this.AntenaLinhaPipa= antenaLinhaPipa;
            this.Id = id;
            this.Km = km;
            this.TipoVeiculo = tipoVeiculo;
            this.Velocidade= velocidade;
            this.Cor= cor;
        }
        public void Entrei ()
        {
         Console.WriteLine($"Entrei Moto Id: {Id}");
            Console.WriteLine($"Entrei Moto KM: {Km}");
            Console.WriteLine($"Entrei Moto do Tipo: {TipoVeiculo}");
            Console.WriteLine($"Entrei Moto do Tipo: {Cor}");
            Console.WriteLine($"Entrei Moto com Velocidade: {Velocidade}");
            Console.WriteLine($"Antena anti Linha Pipa: {AntenaLinhaPipa}");
            Console.WriteLine($"Capa Chuva: {CapaChuva}");
            Console.WriteLine($"Baú: {Bau}");
            Console.WriteLine("");

        }
   
        
            
    }

}