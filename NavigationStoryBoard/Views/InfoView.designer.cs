// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace NavigationStoryBoard.Views
{
    [Register ("InfoView")]
    partial class InfoView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnThird { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnThird != null) {
                btnThird.Dispose ();
                btnThird = null;
            }
        }
    }
}