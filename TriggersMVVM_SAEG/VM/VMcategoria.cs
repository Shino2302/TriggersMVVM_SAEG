using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using TriggersMVVM_SAEG.Data;
using TriggersMVVM_SAEG.Model;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TriggersMVVM_SAEG.VM
{
    public class VMcategoria : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        bool _activadorAnimacionImg; 
        string _imagen;
        ObservableCollection<Mcategorias> _listaCategorias;
        #endregion
        #region CONSTRUCTOR
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();

        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value);}
        }
        public bool ActivadorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetValue(ref _activadorAnimacionImg, value); }
        }
        public string Imagen
        {
            get { return _imagen; }
            set { SetValue(ref _imagen, value); }
        }
        #endregion
        #region PROCESOS
        public void Seleccionar(Mcategorias modelo)
        {
            var index = ListaCategorias.ToList().FindIndex(p => p.descripcion == modelo.descripcion);

            Imagen = modelo.imagen;
            if(index > -1)
            {
                Deseleccionar();
                ActivadorAnimacionImg = true;
                ListaCategorias[index].selected = true;
                ListaCategorias[index].textColor = "#FFFFFF";
                ListaCategorias[index].backgroundColor = "#FF506B";
            }
        }
        public void Deseleccionar()
        {
            ListaCategorias.ForEach((item) =>
            {
                ActivadorAnimacionImg = false;
                item.selected = false;
                item.textColor = "#000";
                item.backgroundColor = "#EAEDF6";
            });
        }
        public async Task ProcesoAsyncrono()
        {

        }
        public void MostrarCategorias()
        {
            //Al hacer esto estamos jalando toda la data
            ListaCategorias = new ObservableCollection<Mcategorias>(Data.Dcategorias.MostrarCategorias());
        }
        #endregion
        #region COMANDOS
        public ICommand ProsesoAsynCommnad => new Command(async () => await ProcesoAsyncrono());
        public ICommand MostrarCategoriasCommnad => new Command(MostrarCategorias);
        public ICommand SeleccionarCommand => new Command<Mcategorias>((p)=>Seleccionar(p));
        #endregion
    }
}
