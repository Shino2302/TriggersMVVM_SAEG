using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TriggersMVVM_SAEG.VM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_SAEG.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categoria : ContentPage
    {
        public Categoria()
        {
            InitializeComponent();
            BindingContext = new VMcategoria(Navigation);
        }
    }
}