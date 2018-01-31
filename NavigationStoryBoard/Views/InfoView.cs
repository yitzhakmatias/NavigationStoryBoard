using System;
using App.Core.ViewModels.Home;
using App.Core.ViewModels.Menu;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace NavigationStoryBoard.Views
{
    [MvxFromStoryboard("NewServiceRequest")]
    public partial class InfoView : BaseViewController<InfoViewModel>
    {
        public InfoView(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Settings View";

            var set = this.CreateBindingSet<InfoView, InfoViewModel>();
            set.Bind(btnThird).To("GoThCommand");
            set.Apply();
        }
    }
}