﻿using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Rock.Lava;
using System.Collections.Generic;
using Rock.Tests.Shared;

namespace Rock.Tests.Integration.Lava
{
    [TestClass]
    public class LegacyLavaUpdaterTest : TestClassBase
    {
        [TestMethod] [Ignore( "need way of mocking RockContext" )]
        public void UpdateLegacyLava()
        {
            LegacyLavaUpdater legacyLavaUpdater = new LegacyLavaUpdater();
            legacyLavaUpdater.FindLegacyLava();

            Assert.Empty( legacyLavaUpdater.SQLUpdateScripts );

        }

        /// <summary>
        /// This test is to confirm that the _url string is not replaced if it isn't in a lava tag
        /// </summary>
        [TestMethod] [Ignore( "need way of mocking RockContext" )]
        public void ReplaceUrlOnNonLavaString()
        {
            LegacyLavaUpdater legacyLavaUpdater = new LegacyLavaUpdater();
            bool isUpdated = false;

            string beforeText = @"This should not get changed query_strings_from_url {{ Person | Attribute: ''Facebook'', ''Url'' }}";
            string afterText = legacyLavaUpdater.ReplaceUrl( beforeText, ref isUpdated );
            Assert.Equal( beforeText, afterText );
        }

        /// <summary>
        /// Confirms that the _url string is replaced if it is in a lava tag
        /// </summary>
        [TestMethod] [Ignore( "need way of mocking RockContext" )]
        public void ReplaceUrlOnLavaString()
        {
            LegacyLavaUpdater legacyLavaUpdater = new LegacyLavaUpdater();
            bool isUpdated = false;

            string beforeText = "<p>_url Legacy Lava {{ Person.Facebook_url }} Legacy Lava </p>";
            string expectedText = "<p>_url Legacy Lava {{ Person.Facebook,'Url' }} Legacy Lava </p>";

            string afterText = legacyLavaUpdater.ReplaceUrl( beforeText, ref isUpdated );
            Assert.Equal( expectedText, afterText );
        }

        /// <summary>
        /// Confirms that the URL replacer will loop through the entire string.
        /// </summary>
        [TestMethod] [Ignore( "need way of mocking RockContext" )]
        public void ReplaceMultipleUrlOnLavaString()
        {
            LegacyLavaUpdater legacyLavaUpdater = new LegacyLavaUpdater();
            bool isUpdated = false;

            string beforeText = "<p>_url Legacy Lava {{ Person.Facebook_url }} {{ Person.Twitter_url }} {{ Person.SnapChat_url }} {{ Person.Instagram_url }} Legacy Lava </p>";
            string expectedText = "<p>_url Legacy Lava {{ Person.Facebook,'Url' }} {{ Person.Twitter,'Url' }} {{ Person.SnapChat,'Url' }} {{ Person.Instagram,'Url' }} Legacy Lava </p>";

            string afterText = legacyLavaUpdater.ReplaceUrl( beforeText, ref isUpdated );
            Assert.Equal( expectedText, afterText );
        }

        [TestMethod] [Ignore( "need way of mocking RockContext" )]
        public void CheckSystemEmail()
        {
            LegacyLavaUpdater legacyLavaUpdater = new LegacyLavaUpdater();
            legacyLavaUpdater.CheckSystemEmail();
        }

        [TestMethod] [Ignore( "need way of mocking RockContext" )]
        public void CheckDotNotation()
        {
            bool isUpdated = false;
            string beforeText = "{% for group in GroupType.Groups %}{% for location in group.Locations %}{% for schedule in location.Schedules %}{{schedule.Name}}{% endfor %}{% endfor %}{% endfor %}";
            string expectedText = "{% for group in GroupType.Groups %}{% for location in group.Locations %}{% for schedule in location.Schedules %}{{schedule.Name}}{% endfor %}{% endfor %}{% endfor %}";
            LegacyLavaUpdater legacyLavaUpdater = new LegacyLavaUpdater();
            string afterText = legacyLavaUpdater.ReplaceDotNotation(beforeText, ref isUpdated );
            Assert.Equal( expectedText, afterText );
        }

        [TestMethod] [Ignore( "need way of mocking RockContext" )]
        public void UpdateLegacyLavaFiles()
        {
            LegacyLavaUpdater legacyLavaUpdater = new LegacyLavaUpdater();
            legacyLavaUpdater.FindLegacyLavaInFiles();

        }

        /// <summary>
        /// Make sure we don't match the Report attribute and output Attribute:'Report'edBy
        /// </summary>
        [TestMethod] [Ignore( "need way of mocking RockContext" )]
        public void CheckDotNotationPartialMatches()
        {
            bool isUpdated = false;
            string beforeText = "<p>{{ Workflow.ReportedBy }},</p>";
            string expectedText = "<p>{{ Workflow | Attribute:'ReportedBy' }},</p>";
            LegacyLavaUpdater legacyLavaUpdater = new LegacyLavaUpdater();
            string afterText = legacyLavaUpdater.ReplaceDotNotation( beforeText, ref isUpdated );
            Assert.Equal( expectedText, afterText );
        }
    }
}
