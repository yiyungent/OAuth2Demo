using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JavaCommon
{
    public enum TimeUnit
    {
        /// <summary>
        /// Time unit representing one thousandth of a microsecond
        /// </summary>
        NANOSECONDS,

        /// <summary>
        /// Time unit representing one thousandth of a millisecond
        /// </summary>
        MICROSECONDS,

        /// <summary>
        /// Time unit representing one thousandth of a second
        /// </summary>
        MILLISECONDS,

        /// <summary>
        /// Time unit representing one second
        /// </summary>
        SECONDS,

        /// <summary>
        /// Time unit representing sixty seconds
        /// </summary>
        MINUTES,

        /// <summary>
        /// Time unit representing sixty minutes
        /// </summary>
        HOURS,

        /// <summary>
        /// Time unit representing twenty four hours
        /// </summary>
        DAYS
    }
}