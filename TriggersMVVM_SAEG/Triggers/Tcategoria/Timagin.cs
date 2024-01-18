using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TriggersMVVM_SAEG.Triggers.Tcategoria
{
    public class Timagin : TriggerAction<Image>
    {
        public bool activation { get; set; }
        protected override async void Invoke(Image sender)
        {
            if(activation == true)
            {
                sender.BackgroundColor = Color.Red;
                //rotacion que tendra, tiempo en milisegundos, tipo de animación
                await sender.RelRotateTo(360, 5000, Easing.BounceOut);
            }
            else
            {
                //Restauramos los valores a su estado inicial
                sender.BackgroundColor = new Image().BackgroundColor;
                sender.Rotation = new Image().Rotation;
            }
        }
    }
}
