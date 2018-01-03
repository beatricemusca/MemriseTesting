﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest1.Memrise.WebApp.Payment
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PaymentPage recording.
    /// </summary>
    [TestModule("71b737bd-9c18-47f4-9e8a-8496512310a0", ModuleType.Recording, 1)]
    public partial class PaymentPage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1.MyTest1Repository repository.
        /// </summary>
        public static MyTest1.MyTest1Repository repo = MyTest1.MyTest1Repository.Instance;

        static PaymentPage instance = new PaymentPage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PaymentPage()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PaymentPage Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MemriseLearningMadeJoyful.Text' at 109;15.", repo.MemriseLearningMadeJoyful.TextInfo, new RecordItemIndex(0));
            repo.MemriseLearningMadeJoyful.Text.Click("109;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'hello{Space}world' with focus on 'MemriseLearningMadeJoyful.Text'.", repo.MemriseLearningMadeJoyful.TextInfo, new RecordItemIndex(1));
            repo.MemriseLearningMadeJoyful.Text.PressKeys("hello{Space}world");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MemriseLearningMadeJoyful.Text'.", repo.MemriseLearningMadeJoyful.TextInfo, new RecordItemIndex(2));
            repo.MemriseLearningMadeJoyful.Text.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '4242424242424242'.", new RecordItemIndex(3));
            Keyboard.Press("4242424242424242");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(4));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(5));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{NumPad1}{NumPad2}{NumPad3}'.", new RecordItemIndex(6));
            Keyboard.Press("{Tab}{NumPad1}{NumPad2}{NumPad3}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MemriseLearningMadeJoyful.PayBtn' at 54;3.", repo.MemriseLearningMadeJoyful.PayBtnInfo, new RecordItemIndex(7));
            repo.MemriseLearningMadeJoyful.PayBtn.Click("54;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MemriseLearningMadeJoyful.Back' at Center.", repo.MemriseLearningMadeJoyful.BackInfo, new RecordItemIndex(8));
            repo.MemriseLearningMadeJoyful.Back.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
