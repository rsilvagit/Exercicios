using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pveiculo;

namespace Pveiculo
{
    public class Carro : Veiculo
    {
        
        public bool Airbag {get; set;}
        public bool Radio {get; set;}
        public bool CameraRe {get; set;}
        
        
        public Carro(bool airbag, bool cameraRe, bool radio,int id, decimal km, string tipoVeiculo, decimal velocidade, string cor): base(id,km,tipoVeiculo,velocidade,cor)
        {
        this.Airbag= airbag;
        this.CameraRe = cameraRe;
        this.Radio = radio;
        this.Id = id;
        this.Km = km;
        this.TipoVeiculo = tipoVeiculo;
        this.Velocidade= velocidade;
        }

         public void teste()
         {
            Console.WriteLine($"Entrei Carro Id: {Id}");
            Console.WriteLine($"Entrei Carro KM: {Km}");
            Console.WriteLine($"Entrei Carro do Tipo: {TipoVeiculo}");
            Console.WriteLine($"Entrei Carro do Tipo: {Cor}");
            Console.WriteLine($"Entrei Carro com Velocidade: {Velocidade}");
            Console.WriteLine($"Airbag: {Airbag}");
            Console.WriteLine($"Camera de Ré: {CameraRe}");
            Console.WriteLine($"Radio: {Radio}");
            Console.WriteLine("");


         }    
        
    
    }

}

