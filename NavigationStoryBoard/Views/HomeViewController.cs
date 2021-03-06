﻿using System;
using App.Core.ViewModels.Home;
using App.Core.ViewModels.Menu;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace NavigationStoryBoard.Views
{
    [MvxFromStoryboard("Main")]
    public partial class HomeViewController : BaseViewController<HomeViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Home View";



            // this.CreateBinding(btnNext).To((HomeViewModel vm) => vm.GoToInfoCommand).Apply();
            /*   var set = this.CreateBindingSet<HomeViewController, HomeViewModel>();
               set.Bind(btnNext).To("GotoSettings");
              // set.Bind(btnNextBinding).To("GotoInfo");
               set.Apply();*/
            this.CreateBinding(btnNext).To((HomeViewModel vm) => vm.GotoSettings).Apply();
        }

        public HomeViewController(IntPtr handle) : base(handle)
        {
        }
    }
}