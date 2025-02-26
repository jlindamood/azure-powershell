// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Simple policy schedule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SimpleSchedulePolicy")]
    public partial class SimpleSchedulePolicy : SchedulePolicy
    {
        /// <summary>
        /// Initializes a new instance of the SimpleSchedulePolicy class.
        /// </summary>
        public SimpleSchedulePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimpleSchedulePolicy class.
        /// </summary>

        /// <param name="scheduleRunFrequency">Frequency of the schedule operation of this policy.
        /// Possible values include: 'Invalid', 'Daily', 'Weekly', 'Hourly'</param>

        /// <param name="scheduleRunDays">List of days of week this schedule has to be run.
        /// </param>

        /// <param name="scheduleRunTimes">List of times of day this schedule has to be run.
        /// </param>

        /// <param name="hourlySchedule">Hourly Schedule of this Policy
        /// </param>

        /// <param name="scheduleWeeklyFrequency">At every number weeks this schedule has to be run.
        /// </param>
        public SimpleSchedulePolicy(string scheduleRunFrequency = default(string), System.Collections.Generic.IList<DayOfWeek?> scheduleRunDays = default(System.Collections.Generic.IList<DayOfWeek?>), System.Collections.Generic.IList<System.DateTime?> scheduleRunTimes = default(System.Collections.Generic.IList<System.DateTime?>), HourlySchedule hourlySchedule = default(HourlySchedule), int? scheduleWeeklyFrequency = default(int?))

        {
            this.ScheduleRunFrequency = scheduleRunFrequency;
            this.ScheduleRunDays = scheduleRunDays;
            this.ScheduleRunTimes = scheduleRunTimes;
            this.HourlySchedule = hourlySchedule;
            this.ScheduleWeeklyFrequency = scheduleWeeklyFrequency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets frequency of the schedule operation of this policy. Possible values include: &#39;Invalid&#39;, &#39;Daily&#39;, &#39;Weekly&#39;, &#39;Hourly&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleRunFrequency")]
        public string ScheduleRunFrequency {get; set; }

        /// <summary>
        /// Gets or sets list of days of week this schedule has to be run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleRunDays")]
        public System.Collections.Generic.IList<DayOfWeek?> ScheduleRunDays {get; set; }

        /// <summary>
        /// Gets or sets list of times of day this schedule has to be run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleRunTimes")]
        public System.Collections.Generic.IList<System.DateTime?> ScheduleRunTimes {get; set; }

        /// <summary>
        /// Gets or sets hourly Schedule of this Policy
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hourlySchedule")]
        public HourlySchedule HourlySchedule {get; set; }

        /// <summary>
        /// Gets or sets at every number weeks this schedule has to be run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleWeeklyFrequency")]
        public int? ScheduleWeeklyFrequency {get; set; }
    }
}