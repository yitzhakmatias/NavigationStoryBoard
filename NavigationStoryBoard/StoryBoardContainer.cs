using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using UIKit;

namespace NavigationStoryBoard
{
   public class StoryBoardContainer : MvxIosViewsContainer
    {
        public override IMvxIosView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
           // return (IMvxIosView)UIStoryboard.FromName("NewServiceRequest", null)
             //   .InstantiateViewController(viewType.Name);
            return (IMvxIosView)UIStoryboard.FromName("Main", null)
                .InstantiateViewController(viewType.Name);
        }
    }

}