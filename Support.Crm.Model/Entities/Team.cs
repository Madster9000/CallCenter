using System.CodeDom.Compiler;
using System.Data.Services;
using System.Data.Services.Common;
using System.Runtime.Serialization;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Metadata;
using Microsoft.Xrm.Sdk.Client;

namespace Support.Crm.Model.Entities
{
    /// <summary>
    /// Набор системных пользователей, которые обычно участвуют в совместной работе. Рабочие группы можно использовать для упрощения предоставления участникам группы общего доступа к записям и данным организации, если участники принадлежат к разным подразделениям.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("team")]
    [GeneratedCode("CrmSvcUtil", "5.0.9690.3739")]
    [DataServiceKey("Id")]
    [IgnoreProperties("Item", "Attributes", "EntityState", "FormattedValues", "RelatedEntities", "ExtensionData")]
    [Entity("TeamSet")]
    public partial class Team : CrmEntity
    {
		
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Team() : 
            base(EntityLogicalName)
        {
        }
		
        public const string EntityLogicalName = "team";
		
        public const int EntityTypeCode = 9;
		
        /// <summary>
        /// Уникальный идентификатор пользователя, несущего основную ответственность за рабочую группу.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("administratorid")]
        public Microsoft.Xrm.Client.CrmEntityReference AdministratorId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("administratorid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("AdministratorId", "administratorid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор подразделения, с которым связана рабочая группа.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Client.CrmEntityReference BusinessUnitId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("BusinessUnitId", "businessunitid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, создавшего рабочую группу.
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
        /// Дата и время создания рабочей группы.
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
        /// Уникальный идентификатор делегата, создавшего рабочую группу.
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
        /// Описание рабочей группы.
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
        /// Адрес электронной почты группы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
        public string EMailAddress
        {
            get
            {
                return this.GetAttributeValue<string>("emailaddress");
            }
            set
            {
                this.SetAttributeValue<string>("EMailAddress", "emailaddress", value);
            }
        }
		
        /// <summary>
        /// Курс обмена валюты, связанной с рабочей группой, по отношению к базовой валюте.
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
        /// Уникальный идентификатор импорта или переноса данных, создавшего эту запись.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iok_specialization")]
        public System.Nullable<int> iok_specialization
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("iok_specialization");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("iok_specialization", "iok_specialization", value);
            }
        }
		
        /// <summary>
        /// Сведения о том, является ли рабочая группа группой подразделения по умолчанию.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
        public System.Nullable<bool> IsDefault
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isdefault");
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор пользователя, внесшего последнее изменение в рабочую группу.
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
        /// Дата и время последнего изменения рабочей группы.
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
        /// Уникальный идентификатор делегата, внесшего последнее изменение в рабочую группу.
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
        /// Название рабочей группы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get
            {
                return this.GetAttributeValue<string>("name");
            }
            set
            {
                this.SetAttributeValue<string>("Name", "name", value);
            }
        }
		
        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("new_new_sort")]
        public System.Nullable<bool> new_new_sort
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("new_new_sort");
            }
            set
            {
                this.SetAttributeValue<System.Nullable<bool>>("new_new_sort", "new_new_sort", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор организации, связанной с рабочей группой.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
            }
        }
		
        /// <summary>
        /// Дата и время переноса записи.
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
        /// Уникальный идентификатор очереди по умолчанию для рабочей группы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public Microsoft.Xrm.Client.CrmEntityReference QueueId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
            }
            set
            {
                this.SetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("QueueId", "queueid", value);
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор рабочей группы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
        public System.Nullable<System.Guid> TeamId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("teamid");
            }
            set
            {
                this.SetPrimaryIdAttributeValue<System.Nullable<System.Guid>>("TeamId", "teamid", value);
            }
        }
		
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.TeamId = value;
            }
        }
		
        /// <summary>
        /// Уникальный идентификатор валюты, связанной с рабочей группой.
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
        /// Номер версии рабочей группы.
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
        /// Фонетическая транскрипция имени рабочей группы, написанная символами хираганы или катаканы.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
        public string YomiName
        {
            get
            {
                return this.GetAttributeValue<string>("yominame");
            }
            set
            {
                this.SetAttributeValue<string>("YomiName", "yominame", value);
            }
        }
		
        /// <summary>
        /// 1:N iok_action_send_sms_team_owningteam
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("iok_action_send_sms_team_owningteam")]
        public System.Collections.Generic.IEnumerable<iok_action_send_SMS> iok_action_send_sms_team_owningteam
        {
            get
            {
                return this.GetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_team_owningteam", null);
            }
            set
            {
                this.SetRelatedEntities<iok_action_send_SMS>("iok_action_send_sms_team_owningteam", "iok_action_send_sms_team_owningteam", null, value);
            }
        }
		
        /// <summary>
        /// 1:N team_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_accounts")]
        public System.Collections.Generic.IEnumerable<Account> team_accounts
        {
            get
            {
                return this.GetRelatedEntities<Account>("team_accounts", null);
            }
            set
            {
                this.SetRelatedEntities<Account>("team_accounts", "team_accounts", null, value);
            }
        }
		
        /// <summary>
        /// 1:N team_activity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_activity")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> team_activity
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("team_activity", null);
            }
            set
            {
                this.SetRelatedEntities<ActivityPointer>("team_activity", "team_activity", null, value);
            }
        }
		
        /// <summary>
        /// 1:N team_annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> team_annotations
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("team_annotations", null);
            }
            set
            {
                this.SetRelatedEntities<Annotation>("team_annotations", "team_annotations", null, value);
            }
        }
		
        /// <summary>
        /// 1:N team_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_contacts")]
        public System.Collections.Generic.IEnumerable<Contact> team_contacts
        {
            get
            {
                return this.GetRelatedEntities<Contact>("team_contacts", null);
            }
            set
            {
                this.SetRelatedEntities<Contact>("team_contacts", "team_contacts", null, value);
            }
        }
		
        /// <summary>
        /// 1:N team_email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_email")]
        public System.Collections.Generic.IEnumerable<Email> team_email
        {
            get
            {
                return this.GetRelatedEntities<Email>("team_email", null);
            }
            set
            {
                this.SetRelatedEntities<Email>("team_email", "team_email", null, value);
            }
        }
		
        /// <summary>
        /// 1:N team_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_incidents")]
        public System.Collections.Generic.IEnumerable<Incident> team_incidents
        {
            get
            {
                return this.GetRelatedEntities<Incident>("team_incidents", null);
            }
            set
            {
                this.SetRelatedEntities<Incident>("team_incidents", "team_incidents", null, value);
            }
        }
		
        /// <summary>
        /// 1:N team_iok_getphonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_iok_getphonecall")]
        public System.Collections.Generic.IEnumerable<iok_getphonecall> team_iok_getphonecall
        {
            get
            {
                return this.GetRelatedEntities<iok_getphonecall>("team_iok_getphonecall", null);
            }
            set
            {
                this.SetRelatedEntities<iok_getphonecall>("team_iok_getphonecall", "team_iok_getphonecall", null, value);
            }
        }
		
        /// <summary>
        /// N:N teammembership_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teammembership_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> teammembership_association
        {
            get
            {
                return this.GetRelatedEntities<SystemUser>("teammembership_association", null);
            }
            set
            {
                this.SetRelatedEntities<SystemUser>("teammembership_association", "teammembership_association", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_team_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_createdonbehalfby")]
        public SystemUser lk_team_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_team_createdonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_team_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_modifiedonbehalfby")]
        public SystemUser lk_team_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_team_modifiedonbehalfby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_teambase_administratorid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("administratorid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_administratorid")]
        public SystemUser lk_teambase_administratorid
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_teambase_administratorid", null);
            }
            set
            {
                this.SetRelatedEntity<SystemUser>("lk_teambase_administratorid", "lk_teambase_administratorid", null, value);
            }
        }
		
        /// <summary>
        /// N:1 lk_teambase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_createdby")]
        public SystemUser lk_teambase_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_teambase_createdby", null);
            }
        }
		
        /// <summary>
        /// N:1 lk_teambase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_modifiedby")]
        public SystemUser lk_teambase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_teambase_modifiedby", null);
            }
        }
    }
}