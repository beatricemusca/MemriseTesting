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

namespace MyTest1.Memrise.WebApp.Start_events
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LaunchInChromeIncognito recording.
    /// </summary>
    [TestModule("99c6a36f-9788-4315-85ec-d3166512f478", ModuleType.Recording, 1)]
    public partial class LaunchInChromeIncognito : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1.MyTest1Repository repository.
        /// </summary>
        public static MyTest1.MyTest1Repository repo = MyTest1.MyTest1Repository.Instance;

        static LaunchInChromeIncognito instance = new LaunchInChromeIncognito();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LaunchInChromeIncognito()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LaunchInChromeIncognito Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://memrise.com' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://memrise.com", "chrome", "", false, false, false, true, false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n    Unlock your learning superpowers with Memrise\r\n    ') on item 'MemriseLearningMadeJoyful.H1TagUnlockYourLearningSuperpowe'.", repo.MemriseLearningMadeJoyful.H1TagUnlockYourLearningSuperpoweInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.MemriseLearningMadeJoyful.H1TagUnlockYourLearningSuperpoweInfo, "InnerText", "\n    Unlock your learning superpowers with Memrise\r\n    ");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
