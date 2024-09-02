using LicUiTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LicUiTests.Steps
{
    [Binding]
    public class BillsSteps
    {
        [Then(@"I confirm the bill was downloaded from the app - (.*)")]
        public void ThenIConfirmTheBillWasDownloadedFromTheApp(string billName)
        {
            Sync.ExplicitWait(2);
            Utils.CheckFileDownloaded(billName);
        }
    }
}
