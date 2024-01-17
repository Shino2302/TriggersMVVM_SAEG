using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TriggersMVVM_SAEG.Model;

namespace TriggersMVVM_SAEG.Data
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias ()
                {
                    descripcion = "Cena",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/tD2h4Km/pokebola.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Hotel",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/tD2h4Km/pokebola.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Fiesta",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/tD2h4Km/pokebola.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias ()
                {
                    descripcion = "Flores",
                    numeroItem= 4512,
                    imagen="https://i.ibb.co/tD2h4Km/pokebola.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                }
            };
        }
    }
}
