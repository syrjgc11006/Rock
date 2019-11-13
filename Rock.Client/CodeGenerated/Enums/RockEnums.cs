//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;

namespace Rock.Client.Enums
{
    #pragma warning disable CS1591
    /// <summary>
    /// </summary>
    public enum AddressInvalidReason
    {
        None = 0x0,
        NotFound = 0x1,
        Vacant = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum AddressStatus
    {
        Invalid = 0x0,
        Valid = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum AgeClassification
    {
        Unknown = 0x0,
        Adult = 0x1,
        Child = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum AssessmentRequestStatus
    {
        Pending = 0x0,
        Complete = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum AttendanceGraphBy
    {
        Total = 0x0,
        Group = 0x1,
        Campus = 0x2,
        Schedule = 0x3,
        Location = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum AttendanceRecordRequiredForCheckIn
    {
        ScheduleNotRequired = 0x0,
        PreSelect = 0x1,
        ScheduleRequired = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum AttendanceRule
    {
        None = 0x0,
        AddOnCheckIn = 0x1,
        AlreadyBelongs = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum AuditType
    {
        Add = 0x0,
        Modify = 0x1,
        Delete = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum AuthenticationServiceType
    {
        Internal = 0x0,
        External = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum BatchStatus
    {
        Pending = 0x0,
        Open = 0x1,
        Closed = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum BlockLocation
    {
        Layout = 0x0,
        Page = 0x1,
        Site = 0x2,
        None = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum ColorDepth
    {
        BlackWhite = 0x0,
        Grayscale8bit = 0x1,
        Grayscale24bit = 0x2,
        Color8bit = 0x3,
        Color24bit = 0x4,
        Undefined = -1,
    }

    /// <summary>
    /// </summary>
    public enum CommunicationRecipientStatus
    {
        Pending = 0x0,
        Delivered = 0x1,
        Failed = 0x2,
        Cancelled = 0x3,
        Opened = 0x4,
        Sending = 0x5,
    }

    /// <summary>
    /// </summary>
    public enum CommunicationStatus
    {
        Transient = 0x0,
        Draft = 0x1,
        PendingApproval = 0x2,
        Approved = 0x3,
        Denied = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum CommunicationType
    {
        RecipientPreference = 0x0,
        Email = 0x1,
        SMS = 0x2,
        PushNotification = 0x3,
    }

    /// <summary>
    /// </summary>
    [Flags]
    public enum ComparisonType
    {
        EqualTo = 0x1,
        NotEqualTo = 0x2,
        StartsWith = 0x4,
        Contains = 0x8,
        DoesNotContain = 0x10,
        IsBlank = 0x20,
        IsNotBlank = 0x40,
        GreaterThan = 0x80,
        GreaterThanOrEqualTo = 0x100,
        LessThan = 0x200,
        LessThanOrEqualTo = 0x400,
        EndsWith = 0x800,
        Between = 0x1000,
        RegularExpression = 0x2000,
    }

    /// <summary>
    /// </summary>
    public enum ContentChannelDateType
    {
        SingleDate = 0x1,
        DateRange = 0x2,
        NoDates = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum ContentChannelItemStatus
    {
        PendingApproval = 0x1,
        Approved = 0x2,
        Denied = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum ContentControlType
    {
        CodeEditor = 0x0,
        HtmlEditor = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum DisplayInNavWhen
    {
        WhenAllowed = 0x0,
        Always = 0x1,
        Never = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum EmailPreference
    {
        EmailAllowed = 0x0,
        NoMassEmails = 0x1,
        DoNotEmail = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum FilterExpressionType
    {
        Filter = 0x0,
        GroupAll = 0x1,
        GroupAny = 0x2,
        GroupAllFalse = 0x3,
        GroupAnyFalse = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum FollowingSuggestedStatus
    {
        PendingNotification = 0x0,
        Suggested = 0x1,
        Ignored = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum Format
    {
        JPG = 0x0,
        GIF = 0x1,
        PNG = 0x2,
        PDF = 0x3,
        Word = 0x4,
        Excel = 0x5,
        Text = 0x6,
        HTML = 0x7,
        Undefined = -1,
    }

    /// <summary>
    /// </summary>
    public enum Gender
    {
        Unknown = 0x0,
        Male = 0x1,
        Female = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum GroupCapacityRule
    {
        None = 0x0,
        Hard = 0x1,
        Soft = 0x2,
    }

    /// <summary>
    /// </summary>
    [Flags]
    public enum GroupLocationPickerMode
    {
        None = 0x0,
        Address = 0x1,
        Named = 0x2,
        Point = 0x4,
        Polygon = 0x8,
        GroupMember = 0x10,
        All = 0x1f,
    }

    /// <summary>
    /// </summary>
    public enum GroupMemberStatus
    {
        Inactive = 0x0,
        Active = 0x1,
        Pending = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum GroupMemberWorkflowTriggerType
    {
        MemberAddedToGroup = 0x0,
        MemberRemovedFromGroup = 0x1,
        MemberStatusChanged = 0x2,
        MemberRoleChanged = 0x3,
        MemberAttendedGroup = 0x4,
        MemberPlacedElsewhere = 0x5,
    }

    /// <summary>
    /// </summary>
    public enum HistoryChangeType
    {
        Record = 0x0,
        Property = 0x1,
        Attribute = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum HistoryVerb
    {
        Add = 0x0,
        Modify = 0x1,
        Delete = 0x2,
        Registered = 0x3,
        Process = 0x4,
        Matched = 0x5,
        Unmatched = 0x6,
        Sent = 0x7,
        Login = 0x8,
        Merge = 0x9,
        AddedToGroup = 0xa,
        RemovedFromGroup = 0xb,
    }

    /// <summary>
    /// </summary>
    public enum IconCssWeight
    {
        Regular = 0x0,
        Solid = 0x1,
        Light = 0x2,
        Thin = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum JobNotificationStatus
    {
        All = 0x1,
        Success = 0x2,
        Error = 0x3,
        None = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum MatchFlag
    {
        None = 0x0,
        Moved = 0x1,
        POBoxClosed = 0x2,
        MovedNoForwarding = 0x3,
        MovedToForeignCountry = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum MeetsGroupRequirement
    {
        Meets = 0x0,
        NotMet = 0x1,
        MeetsWithWarning = 0x2,
        NotApplicable = 0x3,
        Error = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum MergeTemplateOwnership
    {
        Global = 0x0,
        Personal = 0x1,
        PersonalAndGlobal = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum MetricNumericDataType
    {
        Integer = 0x0,
        Decimal = 0x1,
        Currency = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum MetricValueType
    {
        Measure = 0x0,
        Goal = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum MICRStatus
    {
        Success = 0x0,
        Fail = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum MoveType
    {
        None = 0x0,
        Family = 0x1,
        Individual = 0x2,
        Business = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum NcoaType
    {
        None = 0x0,
        NoMove = 0x1,
        Month48Move = 0x2,
        Move = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum NoteApprovalStatus
    {
        PendingApproval = 0x0,
        Approved = 0x1,
        Denied = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum NotificationClassification
    {
        Success = 0x0,
        Info = 0x1,
        Warning = 0x2,
        Danger = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum OptionType
    {
        Agreement = 0x0,
        Frequency = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum PersistedDatasetDataFormat
    {
        JSON = 0x0,
    }

    /// <summary>
    /// </summary>
    public enum PersistedDatasetScriptType
    {
        Lava = 0x0,
    }

    /// <summary>
    /// </summary>
    public enum PersonAliasType
    {
        FromPersonAlias = 0x0,
        ToPersonAlias = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum PrintFrom
    {
        Client = 0x0,
        Server = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum PrintTo
    {
        Default = 0x0,
        Kiosk = 0x1,
        Location = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum Processed
    {
        NotProcessed = 0x0,
        Complete = 0x1,
        ManualUpdateRequired = 0x2,
        ManualUpdateRequiredOrNotProcessed = 0x3,
        All = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum RegistrantsSameFamily
    {
        No = 0x0,
        Yes = 0x1,
        Ask = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum RegistrarOption
    {
        PromptForRegistrar = 0x0,
        PrefillFirstRegistrant = 0x1,
        UseFirstRegistrant = 0x2,
        UseLoggedInPerson = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum RegistrationCostSummaryType
    {
        Cost = 0x0,
        Fee = 0x1,
        Discount = 0x2,
        Total = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum RegistrationFeeType
    {
        Single = 0x0,
        Multiple = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum RegistrationFieldSource
    {
        PersonField = 0x0,
        PersonAttribute = 0x1,
        GroupMemberAttribute = 0x2,
        RegistrantAttribute = 0x4,

        [Obsolete( "Use RegistrantAttribute instead", false )]
        RegistrationAttribute = 0x4,
    }

    /// <summary>
    /// </summary>
    [Flags]
    public enum RegistrationNotify
    {
        None = 0x0,
        RegistrationContact = 0x1,
        GroupFollowers = 0x2,
        GroupLeaders = 0x4,
        All = 0x7,
    }

    /// <summary>
    /// </summary>
    public enum RegistrationPersonFieldType
    {
        FirstName = 0x0,
        LastName = 0x1,
        Campus = 0x2,
        Address = 0x3,
        Email = 0x4,
        Birthdate = 0x5,
        Gender = 0x6,
        MaritalStatus = 0x7,
        MobilePhone = 0x8,
        HomePhone = 0x9,
        WorkPhone = 0xa,
        Grade = 0xb,
        ConnectionStatus = 0xc,
        MiddleName = 0xd,
        AnniversaryDate = 0xe,
    }

    /// <summary>
    /// </summary>
    public enum ReportFieldType
    {
        Property = 0x0,
        Attribute = 0x1,
        DataSelectComponent = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum RequirementCheckType
    {
        Sql = 0x0,
        Dataview = 0x1,
        Manual = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum Resolution
    {
        DPI72 = 0x0,
        DPI150 = 0x1,
        DPI300 = 0x2,
        DPI600 = 0x3,
        Undefined = -1,
    }

    /// <summary>
    /// </summary>
    public enum RSVP
    {
        No = 0x0,
        Yes = 0x1,
        Maybe = 0x2,
        Unknown = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum ScheduledAttendanceItemStatus
    {
        Pending = 0x0,
        Confirmed = 0x1,
        Declined = 0x2,
        Unscheduled = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum SchedulerResourceGroupMemberFilterType
    {
        ShowMatchingPreference = 0x0,
        ShowAllGroupMembers = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum SchedulerResourceListSourceType
    {
        Group = 0x0,
        AlternateGroup = 0x1,
        DataView = 0x2,
    }

    /// <summary>
    /// </summary>
    [Flags]
    public enum ScheduleType
    {
        None = 0x0,
        Weekly = 0x1,
        Custom = 0x2,
        Named = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum SegmentCriteria
    {
        All = 0x0,
        Any = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum SignatureDocumentAction
    {
        Email = 0x0,
        Embed = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum SignatureDocumentStatus
    {
        None = 0x0,
        Sent = 0x1,
        Signed = 0x2,
        Cancelled = 0x3,
        Expired = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum SiteType
    {
        Web = 0x0,
        Mobile = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum SpecialRole
    {
        None = 0x0,
        AllUsers = 0x1,
        AllAuthenticatedUsers = 0x2,
        AllUnAuthenticatedUsers = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum StreakOccurrenceFrequency
    {
        Daily = 0x0,
        Weekly = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum StreakStructureType
    {
        Group = 0x1,
        GroupType = 0x2,
        GroupTypePurpose = 0x3,
        CheckInConfig = 0x4,
    }

    /// <summary>
    /// </summary>
    public enum TagType
    {
        Inline = 0x1,
        Block = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum TransactionGraphBy
    {
        Total = 0x0,
        FinancialAccount = 0x1,
        Campus = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum UpdatedAddressType
    {
        None = 0x0,
        Residential = 0x1,
        Business = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum ViewMode
    {
        Cards = 0x0,
        Grid = 0x1,
    }

    /// <summary>
    /// </summary>
    public enum WorkflowLoggingLevel
    {
        None = 0x0,
        Workflow = 0x1,
        Activity = 0x2,
        Action = 0x3,
    }

    /// <summary>
    /// </summary>
    public enum WorkflowTriggerCondition
    {
        StatusChanged = 0x0,
        Manual = 0x1,
        IsComplete = 0x2,
    }

    /// <summary>
    /// </summary>
    public enum WorkflowTriggerType
    {
        PreSave = 0x0,
        PostSave = 0x1,
        PreDelete = 0x2,
        PostDelete = 0x3,
        ImmediatePostSave = 0x4,
        PostAdd = 0x5,
    }

    /// <summary>
    /// </summary>
    public enum WorkflowTriggerValueChangeType
    {
        ChangeFromTo = 0x0,
        ValueEqual = 0x1,
    }

    #pragma warning restore CS1591
}
