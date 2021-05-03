/*
 * CDS - GtmEntries
 *
 * CDS - GtmEntries
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace APIMDemo.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponseDefault5Value : IEquatable<InlineResponseDefault5Value>
    { 
        /// <summary>
        /// @odata.etag
        /// </summary>
        /// <value>@odata.etag</value>
        [DataMember(Name="@odata.etag")]
        public string OdataEtag { get; set; }

        /// <summary>
        /// nickname
        /// </summary>
        /// <value>nickname</value>
        [DataMember(Name="nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// fullname
        /// </summary>
        /// <value>fullname</value>
        [DataMember(Name="fullname")]
        public string Fullname { get; set; }

        /// <summary>
        /// firstname
        /// </summary>
        /// <value>firstname</value>
        [DataMember(Name="firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// lastname
        /// </summary>
        /// <value>lastname</value>
        [DataMember(Name="lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// azureactivedirectoryobjectid
        /// </summary>
        /// <value>azureactivedirectoryobjectid</value>
        [DataMember(Name="azureactivedirectoryobjectid")]
        public string Azureactivedirectoryobjectid { get; set; }

        /// <summary>
        /// systemuserid
        /// </summary>
        /// <value>systemuserid</value>
        [DataMember(Name="systemuserid")]
        public string Systemuserid { get; set; }

        /// <summary>
        /// ownerid
        /// </summary>
        /// <value>ownerid</value>
        [DataMember(Name="ownerid")]
        public string Ownerid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault5Value {\n");
            sb.Append("  OdataEtag: ").Append(OdataEtag).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Fullname: ").Append(Fullname).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Azureactivedirectoryobjectid: ").Append(Azureactivedirectoryobjectid).Append("\n");
            sb.Append("  Systemuserid: ").Append(Systemuserid).Append("\n");
            sb.Append("  Ownerid: ").Append(Ownerid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponseDefault5Value)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault5Value instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault5Value to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault5Value other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OdataEtag == other.OdataEtag ||
                    OdataEtag != null &&
                    OdataEtag.Equals(other.OdataEtag)
                ) && 
                (
                    Nickname == other.Nickname ||
                    Nickname != null &&
                    Nickname.Equals(other.Nickname)
                ) && 
                (
                    Fullname == other.Fullname ||
                    Fullname != null &&
                    Fullname.Equals(other.Fullname)
                ) && 
                (
                    Firstname == other.Firstname ||
                    Firstname != null &&
                    Firstname.Equals(other.Firstname)
                ) && 
                (
                    Lastname == other.Lastname ||
                    Lastname != null &&
                    Lastname.Equals(other.Lastname)
                ) && 
                (
                    Azureactivedirectoryobjectid == other.Azureactivedirectoryobjectid ||
                    Azureactivedirectoryobjectid != null &&
                    Azureactivedirectoryobjectid.Equals(other.Azureactivedirectoryobjectid)
                ) && 
                (
                    Systemuserid == other.Systemuserid ||
                    Systemuserid != null &&
                    Systemuserid.Equals(other.Systemuserid)
                ) && 
                (
                    Ownerid == other.Ownerid ||
                    Ownerid != null &&
                    Ownerid.Equals(other.Ownerid)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (OdataEtag != null)
                    hashCode = hashCode * 59 + OdataEtag.GetHashCode();
                    if (Nickname != null)
                    hashCode = hashCode * 59 + Nickname.GetHashCode();
                    if (Fullname != null)
                    hashCode = hashCode * 59 + Fullname.GetHashCode();
                    if (Firstname != null)
                    hashCode = hashCode * 59 + Firstname.GetHashCode();
                    if (Lastname != null)
                    hashCode = hashCode * 59 + Lastname.GetHashCode();
                    if (Azureactivedirectoryobjectid != null)
                    hashCode = hashCode * 59 + Azureactivedirectoryobjectid.GetHashCode();
                    if (Systemuserid != null)
                    hashCode = hashCode * 59 + Systemuserid.GetHashCode();
                    if (Ownerid != null)
                    hashCode = hashCode * 59 + Ownerid.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefault5Value left, InlineResponseDefault5Value right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefault5Value left, InlineResponseDefault5Value right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
