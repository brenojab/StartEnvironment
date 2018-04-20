using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StartEnvironments.Views
{
  public class BaseContentPage
  {
    public virtual StackLayout ContentHeader { get; set; }
    public virtual StackLayout ContentMaster { get; set; }
    public virtual StackLayout ContentBottom { get; set; }

  }
}
