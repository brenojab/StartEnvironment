using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StartEnvironments.Views
{
  public class AmbientePage
  {
    public StackLayout MainStack;

    /// <summary>
    /// Adiciona os componentes na tela de ambientes.
    /// </summary>
    public virtual void AddAmbienteComponentes()
    {
      MainStack = new StackLayout()
      {
        VerticalOptions = LayoutOptions.StartAndExpand
      };

      //var btnLogin = RMSBaseControl<RMSButton>.Control;
      //btnLogin.Text = Translator["SEduCaptionLoginFacebook"];

      //btnLogin.SetBinding<ILoginViewModel>(RMSButton.CommandProperty, f => f.LoginOnFacebookCommand);
      //btnLogin.SetBinding<BaseViewModel>(StackLayout.IsVisibleProperty, vm => vm.Config.GUID, BindingMode.OneWay, new ConverterStringIsNullOrEmptyToBool(false));
      //StackLoginFacebook.Children.Add(btnLogin);

      //btnLogin.BackgroundColor = Color.FromHex("#415F9B");
      //btnLogin.TextColor = Color.White;
      //// Binding das propriedades.
      //StackLoginFacebook.SetBinding<ILoginViewModel>(RMSButton.IsVisibleProperty, vm => vm.LoginOnFacebookButtonVisibile);

      //this.ContentMaster.Children.Add(StackLoginFacebook);

      

      var btnAddAmbiente = new Button()
      {
        Text = "Adicionar",
        BackgroundColor = Color.BlueViolet
      };

      var entryVersaoHost = new Entry()
      {
        Placeholder = "Versão do Host",
        
      };

      var entryPorta = new Entry()
      {
        Placeholder = "Porta do Host"
      };


    }
  }
}
