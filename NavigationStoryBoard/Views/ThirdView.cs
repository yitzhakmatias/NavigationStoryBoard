using System;
using App.Core.ViewModels.Home;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace NavigationStoryBoard.Views
{
    [MvxFromStoryboard("NewServiceRequest")]
    public partial class ThirdView : BaseViewController<ThirdViewModel>
    {
        public ThirdView(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Settings View";

            var set = this.CreateBindingSet<ThirdView, ThirdViewModel>();
            set.Bind(btnBack).To("goBack");
            set.Apply();
        }
    }
}