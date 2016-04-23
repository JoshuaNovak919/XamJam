using Plugin.XamJam.BugHound.Abstractions;
using System;
using System.Threading;

namespace Plugin.XamJam.BugHound
{
    /// <summary>
    /// <see cref="IBugHoundHelper"/>
    /// </summary>
    public class BugHoundHelperImplementation : IBugHoundHelper
    {
        /// <summary>
        /// <see cref="IBugHoundHelper.ThreadName"/>
        /// </summary>
        public string ThreadName => "T-"+ Environment.CurrentManagedThreadId;
    }
}