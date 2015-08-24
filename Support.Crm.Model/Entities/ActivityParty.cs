namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Лицо или группа, связанные с действием. У действия может несколько сторон действия.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activityparty")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9690.3739")]
    [System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    [System.Data.Services.IgnorePropertiesAttribute("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Microsoft.Xrm.Client.Metadata.EntityAttribute("ActivityPartySet")]
    public partial class ActivityParty : Microsoft.Xrm.Client.CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ActivityParty() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "activityparty";
		
        public const int EntityTypeCode = 135;
		
        /// <summary>
        /// Уникальный идентификатор действия, связанного со стороной действия ("cторона" - это любой человек, связанный с действием).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public Microsoft.Xrm.Client.CrmEntityReference ActivityId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ActivityId", "activityid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор стороны действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
        public System.Nullable<System.Guid> ActivityPartyId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("activitypartyid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("ActivityPartyId", "activitypartyid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.ActivityPartyId = value;
            }
        }
		
        /// <summary>
        /// Адрес электронной почты, на который доставляется электронная почта и с которой связана целевая сущность.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressused")]
        public string AddressUsed
        {
            get
            {
                return this.GetAttributeValue<string>("addressused");
            }
            set
            {
                this.SetAttributeValue<string>("AddressUsed", "addressused", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, следует ли разрешить отправку электронной почты стороне действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
        public System.Nullable<bool> DoNotEmail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
            }
        }
		
        /// <summary>
        /// Сведения о том, следует ли разрешить отправку факсов стороне действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
        public System.Nullable<bool> DoNotFax
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешены ли звонки интересу.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
        public System.Nullable<bool> DoNotPhone
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
            }
        }
		
        /// <summary>
        /// Сведения о том, разрешена ли отправка писем интересу.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
        public System.Nullable<bool> DoNotPostalMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
            }
        }
		
        /// <summary>
        /// Объем усилий, используемых ресурсом в действии встречи по сервису.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effort")]
        public System.Nullable<double> Effort
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("effort");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<double>>("Effort", "effort", value);
            }
        }
		
        /// <summary>
        /// Только для внутреннего использования.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
        public string ExchangeEntryId
        {
            get
            {
                return this.GetAttributeValue<string>("exchangeentryid");
            }
            set
            {
                this.SetAttributeValue<string>("ExchangeEntryId", "exchangeentryid", value);
            }
        }
		
        /// <summary>
        /// Тип экземпляра повторяющегося ряда.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
        public System.Nullable<int> InstanceTypeCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("instancetypecode");
            }
        }
		
        /// <summary>
        /// Сведения о том, удалена ли базовая запись сущности.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeleted")]
        public System.Nullable<bool> IsPartyDeleted
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ispartydeleted");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя или рабочей группы, ответственных за activity_party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Client.CrmEntityReference OwnerId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
        }
		
        /// <summary>
        /// Роль лица в действии (например, отправитель, получатель, получатель копии, получатель скрытой копии, необязательное лицо, организатор или ответственный).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
        public System.Nullable<int> ParticipationTypeMask
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("participationtypemask");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ParticipationTypeMask", "participationtypemask", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор стороны, связанной с действием.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        public Microsoft.Xrm.Client.CrmEntityReference PartyId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partyid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("PartyId", "partyid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор спецификации ресурса для стороны действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
        public Microsoft.Xrm.Client.CrmEntityReference ResourceSpecId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("resourcespecid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ResourceSpecId", "resourcespecid", value);
            }
        }
		
        /// <summary>
        /// Плановое время окончания действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend");
            }
        }
		
        /// <summary>
        /// Плановое время начала действия.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart");
            }
        }
		
        /// <summary>
        /// 
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
        /// N:1 account_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
        public Account account_activity_parties
        {
            get
            {
                return this.GetRelatedEntity<Account>("account_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntity<Account>("account_activity_parties", "account_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// N:1 activitypointer_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_activity_parties")]
        public ActivityPointer activitypointer_activity_parties
        {
            get
            {
                return this.GetRelatedEntity<ActivityPointer>("activitypointer_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntity<ActivityPointer>("activitypointer_activity_parties", "activitypointer_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// N:1 contact_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
        public Contact contact_activity_parties
        {
            get
            {
                return this.GetRelatedEntity<Contact>("contact_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntity<Contact>("contact_activity_parties", "contact_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// N:1 email_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_parties")]
        public Email email_activity_parties
        {
            get
            {
                return this.GetRelatedEntity<Email>("email_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntity<Email>("email_activity_parties", "email_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// N:1 incident_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_activity_parties")]
        public Incident incident_activity_parties
        {
            get
            {
                return this.GetRelatedEntity<Incident>("incident_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntity<Incident>("incident_activity_parties", "incident_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// N:1 iok_action_send_SMS_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_SMS_activity_parties")]
        public iok_action_send_SMS iok_action_send_SMS_activity_parties
        {
            get
            {
                return this.GetRelatedEntity<iok_action_send_SMS>("iok_action_send_SMS_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntity<iok_action_send_SMS>("iok_action_send_SMS_activity_parties", "iok_action_send_SMS_activity_parties", null, value);
            }
        }
		
        /// <summary>
        /// N:1 system_user_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
        public SystemUser system_user_activity_parties
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("system_user_activity_parties", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("system_user_activity_parties", "system_user_activity_parties", null, value);
            }
        }
    }
}