namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// ��������, ������������ � ������� ���������� ����������� �����.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("email")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("EmailSet")]
    public partial class Email : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Email() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "email";
		
        public const int EntityTypeCode = 4202;
		
        /// <summary>
        /// ���������� ������������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public System.Nullable<System.Guid> ActivityId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("activityid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("ActivityId", "activityid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.ActivityId = value;
            }
        }
		
        /// <summary>
        /// ��� ��������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypecode")]
        public string ActivityTypeCode
        {
            get
            {
                return this.GetAttributeValue<string>("activitytypecode");
            }
        }
		
        /// <summary>
        /// ������������ �������� ����������� ����� � �������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualdurationminutes")]
        public System.Nullable<int> ActualDurationMinutes
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("actualdurationminutes");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("ActualDurationMinutes", "actualdurationminutes", value);
            }
        }
		
        /// <summary>
        /// ����� ���������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualend")]
        public System.Nullable<System.DateTime> ActualEnd
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualend");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("ActualEnd", "actualend", value);
            }
        }
		
        /// <summary>
        /// ����� ������ �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstart")]
        public System.Nullable<System.DateTime> ActualStart
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualstart");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("ActualStart", "actualstart", value);
            }
        }
		
        /// <summary>
        /// ���������� ������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bcc")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Bcc
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("bcc");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("Bcc", "bcc", value);
            }
        }
		
        /// <summary>
        /// ��������� ��������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
        public string Category
        {
            get
            {
                return this.GetAttributeValue<string>("category");
            }
            set
            {
                this.SetAttributeValue<string>("Category", "category", value);
            }
        }
		
        /// <summary>
        /// ���������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cc")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Cc
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("cc");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("Cc", "cc", value);
            }
        }
		
        /// <summary>
        /// ���������, ����������� �� ������ ������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("compressed")]
        public System.Nullable<bool> Compressed
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("compressed");
            }
        }
		
        /// <summary>
        /// ���������� ������������� ������������, ���������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Client.CrmEntityReference CreatedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }
		
        /// <summary>
        /// ���� � ����� �������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }
		
        /// <summary>
        /// ���������� ������������� ��������������� ������������, ���������� ��������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Client.CrmEntityReference CreatedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }
		
        /// <summary>
        /// ����� ������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryattempts")]
        public System.Nullable<int> DeliveryAttempts
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("deliveryattempts");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("DeliveryAttempts", "deliveryattempts", value);
            }
        }
		
        /// <summary>
        /// ����������� ������������� ��������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryreceiptrequested")]
        public System.Nullable<bool> DeliveryReceiptRequested
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("deliveryreceiptrequested");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DeliveryReceiptRequested", "deliveryreceiptrequested", value);
            }
        }
		
        /// <summary>
        /// ����� ��������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get
            {
                return this.GetAttributeValue<string>("description");
            }
            set
            {
                this.SetAttributeValue<string>("Description", "description", value);
            }
        }
		
        /// <summary>
        /// ��� ����������� ��������� ����������� ����� (�������� ��� ���������).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("directioncode")]
        public System.Nullable<bool> DirectionCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("directioncode");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("DirectionCode", "directioncode", value);
            }
        }
		
        /// <summary>
        /// �������� ���� ������, ��������� � ���������� ����������� �����, �� ��������� � ������� ������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
            }
        }
		
        /// <summary>
        /// ����������� ��������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("from")]
        public System.Collections.Generic.IEnumerable<ActivityParty> From
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("from");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("From", "from", value);
            }
        }
		
        /// <summary>
        /// ���������� ������������� ������� ��� �������� ������, ���������� ��� ������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("ImportSequenceNumber", "importsequencenumber", value);
            }
        }
		
        /// <summary>
        /// �������� � ���, ��� �� ��������� ���� �� �������� ����������� ����� ��� ����� ���������� ���������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbilled")]
        public System.Nullable<bool> IsBilled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isbilled");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("IsBilled", "isbilled", value);
            }
        }
		
        /// <summary>
        /// �������� � ���, �������� �� �������� ������� ��������� ��� ��������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregularactivity")]
        public System.Nullable<bool> IsRegularActivity
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isregularactivity");
            }
        }
		
        /// <summary>
        /// �������� � ���, ���� �� ��������� ����������� ����� ������� �������� ������-��������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowcreated")]
        public System.Nullable<bool> IsWorkflowCreated
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isworkflowcreated");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("IsWorkflowCreated", "isworkflowcreated", value);
            }
        }
		
        /// <summary>
        /// ���������� ������������� ��������� ����������� �����. ������������ ������ ��� �������� ��������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messageid")]
        public string MessageId
        {
            get
            {
                return this.GetAttributeValue<string>("messageid");
            }
            set
            {
                this.SetAttributeValue<string>("MessageId", "messageid", value);
            }
        }
		
        /// <summary>
        /// ������ ��� ����������� �������������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messageiddupcheck")]
        public System.Nullable<System.Guid> MessageIdDupCheck
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("messageiddupcheck");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.Guid>>("MessageIdDupCheck", "messageiddupcheck", value);
            }
        }
		
        /// <summary>
        /// ������ ���� MIME ��������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
        public string MimeType
        {
            get
            {
                return this.GetAttributeValue<string>("mimetype");
            }
            set
            {
                this.SetAttributeValue<string>("MimeType", "mimetype", value);
            }
        }
		
        /// <summary>
        /// ���������� ������������� ���������� ������������, ����������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Client.CrmEntityReference ModifiedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }
		
        /// <summary>
        /// ���� � ����� ���������� ��������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }
		
        /// <summary>
        /// ���������� ������������� ���������� ��������������� ������������, ����������� ��������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Client.CrmEntityReference ModifiedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_rule")]
        public string New_rule
        {
            get
            {
                return this.GetAttributeValue<string>("new_rule");
            }
            set
            {
                this.SetAttributeValue<string>("New_rule", "new_rule", value);
            }
        }
		
        /// <summary>
        /// �� ������������ ����
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_visited")]
        public System.Nullable<bool> New_visited
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_visited");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("New_visited", "new_visited", value);
            }
        }
		
        /// <summary>
        /// ����������� ��� ����� ��������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notifications")]
        public System.Nullable<int> Notifications
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("notifications");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("Notifications", "notifications", value);
            }
        }
		
        /// <summary>
        /// ���� � ����� �������� ������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("OverriddenCreatedOn", "overriddencreatedon", value);
            }
        }
		
        /// <summary>
        /// ���������� ������������� ������������ ��� ������� ������, ������������� �� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Client.CrmEntityReference OwnerId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("OwnerId", "ownerid", value);
            }
        }
		
        /// <summary>
        /// Business unit that owns the e-mail activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Client.CrmEntityReference OwningBusinessUnit
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
            }
        }
		
        /// <summary>
        /// ���������� ������������� ������� ������, ������������� �� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Client.CrmEntityReference OwningTeam
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
            }
        }
		
        /// <summary>
        /// ���������� ������������� ������������, �������������� ��  �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Client.CrmEntityReference OwningUser
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
            }
        }
		
        /// <summary>
        /// ��� ���������� ��������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public System.Nullable<int> PriorityCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("prioritycode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("PriorityCode", "prioritycode", value);
            }
        }
		
        /// <summary>
        /// ���������, ��� ��������� ����������� � ���������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("readreceiptrequested")]
        public System.Nullable<bool> ReadReceiptRequested
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("readreceiptrequested");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("ReadReceiptRequested", "readreceiptrequested", value);
            }
        }
		
        /// <summary>
        /// Unique identifier of the object with which the e-mail is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Client.CrmEntityReference RegardingObjectId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("RegardingObjectId", "regardingobjectid", value);
            }
        }
		
        /// <summary>
        /// ��������������� ������������ �������� ����������� ����� � �������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes");
            }
        }
		
        /// <summary>
        /// �������� ����� ��������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("ScheduledEnd", "scheduledend", value);
            }
        }
		
        /// <summary>
        /// �������� ����� ������ �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<System.DateTime>>("ScheduledStart", "scheduledstart", value);
            }
        }
		
        /// <summary>
        /// ����������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sender")]
        public string Sender
        {
            get
            {
                return this.GetAttributeValue<string>("sender");
            }
            set
            {
                this.SetAttributeValue<string>("Sender", "sender", value);
            }
        }
		
        /// <summary>
        /// ���������� ������������� ���������� �������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        public Microsoft.Xrm.Client.CrmEntityReference ServiceId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("serviceid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ServiceId", "serviceid", value);
            }
        }
		
        /// <summary>
        /// ��������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<int> StateCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("statecode");
            }
        }
		
        /// <summary>
        /// ������� ��������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public System.Nullable<int> StatusCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("statuscode");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("StatusCode", "statuscode", value);
            }
        }
		
        /// <summary>
        /// ������������ �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subcategory")]
        public string Subcategory
        {
            get
            {
                return this.GetAttributeValue<string>("subcategory");
            }
            set
            {
                this.SetAttributeValue<string>("Subcategory", "subcategory", value);
            }
        }
		
        /// <summary>
        /// ����, ��������� � ��������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get
            {
                return this.GetAttributeValue<string>("subject");
            }
            set
            {
                this.SetAttributeValue<string>("Subject", "subject", value);
            }
        }
		
        /// <summary>
        /// �������� �������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("submittedby")]
        public string SubmittedBy
        {
            get
            {
                return this.GetAttributeValue<string>("submittedby");
            }
            set
            {
                this.SetAttributeValue<string>("SubmittedBy", "submittedby", value);
            }
        }
		
        /// <summary>
        /// ������ ��� ����������� �������������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("TimeZoneRuleVersionNumber", "timezoneruleversionnumber", value);
            }
        }
		
        /// <summary>
        /// ������ ������-����������� ����������� ����� � ������ �� ������ �����������, ����� ��� ������������ � �������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("to")]
        public System.Collections.Generic.IEnumerable<ActivityParty> To
        {
            get
            {
                return this.GetAttributeCollectionValue<ActivityParty>("to");
            }
            set
            {
                this.SetAttributeCollectionValue<ActivityParty>("To", "to", value);
            }
        }
		
        /// <summary>
        /// ������ �� ������� ������� ����������� ����� �����������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("torecipients")]
        public string ToRecipients
        {
            get
            {
                return this.GetAttributeValue<string>("torecipients");
            }
            set
            {
                this.SetAttributeValue<string>("ToRecipients", "torecipients", value);
            }
        }
		
        /// <summary>
        /// ������������ ������ ������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingtoken")]
        public string TrackingToken
        {
            get
            {
                return this.GetAttributeValue<string>("trackingtoken");
            }
            set
            {
                this.SetAttributeValue<string>("TrackingToken", "trackingtoken", value);
            }
        }
		
        /// <summary>
        /// ���������� ������������� ������, ��������� � ���������� ����������� �����.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Client.CrmEntityReference TransactionCurrencyId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("TransactionCurrencyId", "transactioncurrencyid", value);
            }
        }
		
        /// <summary>
        /// ��� �������� �����, ���������������� ��� �������� ������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<int>>("UTCConversionTimeZoneCode", "utcconversiontimezonecode", value);
            }
        }
		
        /// <summary>
        /// ����� ������ ������������ ���������.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }
		
        /// <summary>
        /// 1:N email_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> email_activity_parties
        {
            get
            {
                return this.GetRelatedEntities<ActivityParty>("email_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityParty>("email_activity_parties", "email_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// 1:N Email_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Email_Annotation
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("Email_Annotation", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("Email_Annotation", "Email_Annotation", null, value);
            }
        }
		
        /// <summary>
        /// N:1 Account_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Emails")]
        public Account Account_Emails
        {
            get
            {
                return this.GetRelatedEntity<Account>("Account_Emails", null);
            }
            set
            {
                this.SetRelatedEntity<Account>("Account_Emails", "Account_Emails", null, value);
            }
        }
		
        /// <summary>
        /// N:1 activity_pointer_email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_email")]
        public ActivityPointer activity_pointer_email
        {
            get
            {
                return this.GetRelatedEntity<ActivityPointer>("activity_pointer_email", null);
            }
            set
            {
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_email", "activity_pointer_email", null, value);
            }
        }
		
        /// <summary>
        /// N:1 Contact_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Emails")]
        public Contact Contact_Emails
        {
            get
            {
                return this.GetRelatedEntity<Contact>("Contact_Emails", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("Contact_Emails", "Contact_Emails", null, value);
            }
        }
		
        /// <summary>
        /// N:1 Incident_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Emails")]
        public Incident Incident_Emails
        {
            get
            {
                return this.GetRelatedEntity<Incident>("Incident_Emails", null);
            }
            set
            {
                this.SetRelatedEntity<Incident>("Incident_Emails", "Incident_Emails", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_getphonecall_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_getphonecall_Emails")]
        public iok_getphonecall iok_getphonecall_Emails
        {
            get
            {
                return this.GetRelatedEntity<iok_getphonecall>("iok_getphonecall_Emails", null);
            }
            set
            {
                this.SetRelatedEntity<iok_getphonecall>("iok_getphonecall_Emails", "iok_getphonecall_Emails", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_email_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdby")]
        public SystemUser lk_email_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_email_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_email_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdonbehalfby")]
        public SystemUser lk_email_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_email_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_email_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedby")]
        public SystemUser lk_email_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_email_modifiedby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_email_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedonbehalfby")]
        public SystemUser lk_email_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_email_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 new_probe_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_probe_Emails")]
        public New_Probe new_probe_Emails
        {
            get
            {
                return this.GetRelatedEntity<New_Probe>("new_probe_Emails", null);
            }
            set
            {
                this.SetRelatedEntity<New_Probe>("new_probe_Emails", "new_probe_Emails", null, value);
            }
        }
		
        /// <summary>
        /// N:1 new_shtrafy_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("new_shtrafy_Emails")]
        public new_shtrafy new_shtrafy_Emails
        {
            get
            {
                return this.GetRelatedEntity<new_shtrafy>("new_shtrafy_Emails", null);
            }
            set
            {
                this.SetRelatedEntity<new_shtrafy>("new_shtrafy_Emails", "new_shtrafy_Emails", null, value);
            }
        }
		
        /// <summary>
        /// N:1 svk_project_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("svk_project_Emails")]
        public svk_project svk_project_Emails
        {
            get
            {
                return this.GetRelatedEntity<svk_project>("svk_project_Emails", null);
            }
            set
            {
                this.SetRelatedEntity<svk_project>("svk_project_Emails", "svk_project_Emails", null, value);
            }
        }
		
        /// <summary>
        /// N:1 user_email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_email")]
        public SystemUser user_email
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("user_email", null);
            }
        }
    }
}