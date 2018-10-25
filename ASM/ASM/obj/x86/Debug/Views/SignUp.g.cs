﻿#pragma checksum "E:\FPT\WindowFormC#\ASM\ASM\Views\SignUp.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C6564FF97A405502AF96A8604916ADB8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASM.Views
{
    partial class SignUp : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\SignUp.xaml line 16
                {
                    this.ParentStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // Views\SignUp.xaml line 47
                {
                    this.MyAvatar = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // Views\SignUp.xaml line 85
                {
                    this.ToLogin = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.ToLogin).Tapped += this.TapToLogin;
                }
                break;
            case 5: // Views\SignUp.xaml line 79
                {
                    this.BtnSignup = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BtnSignup).Click += this.Handle_Signup;
                }
                break;
            case 6: // Views\SignUp.xaml line 80
                {
                    this.BtnReset = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // Views\SignUp.xaml line 76
                {
                    this.Birthday = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.Birthday).DateChanged += this.Change_Birthday;
                }
                break;
            case 8: // Views\SignUp.xaml line 70
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element8 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element8).Checked += this.Select_Gender;
                }
                break;
            case 9: // Views\SignUp.xaml line 71
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element9 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element9).Checked += this.Select_Gender;
                }
                break;
            case 10: // Views\SignUp.xaml line 72
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element10 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element10).Checked += this.Select_Gender;
                }
                break;
            case 11: // Views\SignUp.xaml line 64
                {
                    this.Phone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 12: // Views\SignUp.xaml line 65
                {
                    this.error_Phone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Views\SignUp.xaml line 59
                {
                    this.Address = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14: // Views\SignUp.xaml line 60
                {
                    this.error_Add = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Views\SignUp.xaml line 54
                {
                    this.Introduction = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16: // Views\SignUp.xaml line 55
                {
                    this.error_Intro = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\SignUp.xaml line 49
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.Capture_Photo;
                }
                break;
            case 18: // Views\SignUp.xaml line 50
                {
                    global::Windows.UI.Xaml.Controls.Button element18 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element18).Click += this.Select_Photo;
                }
                break;
            case 19: // Views\SignUp.xaml line 45
                {
                    this.ImageUrl = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20: // Views\SignUp.xaml line 39
                {
                    this.LastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 21: // Views\SignUp.xaml line 40
                {
                    this.error_Lname = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22: // Views\SignUp.xaml line 41
                {
                    this.lastName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23: // Views\SignUp.xaml line 33
                {
                    this.FirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 24: // Views\SignUp.xaml line 34
                {
                    this.error_Fname = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25: // Views\SignUp.xaml line 35
                {
                    this.firstName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26: // Views\SignUp.xaml line 28
                {
                    this.Password = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 27: // Views\SignUp.xaml line 29
                {
                    this.error_Password = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28: // Views\SignUp.xaml line 22
                {
                    this.Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 29: // Views\SignUp.xaml line 23
                {
                    this.error_Email = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 30: // Views\SignUp.xaml line 24
                {
                    this.email = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
