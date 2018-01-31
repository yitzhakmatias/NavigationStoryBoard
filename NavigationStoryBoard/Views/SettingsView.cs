using System;
using App.Core.ViewModels.Menu;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace NavigationStoryBoard.Views
{
    [MvxFromStoryboard("NewServiceRequest")]
    public partial class SettingsView : BaseViewController<SettingsViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Settings View";

           /* var set = this.CreateBindingSet<SettingsView, SettingsViewModel>();
            set.Bind(btnBack).To("GoHomeCommand");
            set.Apply();*/

            this.CreateBinding(btnBack).To((SettingsViewModel vm) => vm.GoHomeCommand).Apply();

        }

        public SettingsView(IntPtr handle) : base(handle)
        {

        }
    }
}