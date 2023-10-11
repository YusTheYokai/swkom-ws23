using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Rest.Model {
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class NewCorrespondent : IEquatable<NewCorrespondent> {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [DataMember(Name="match", EmitDefaultValue=true)]
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets MatchingAlgorithm
        /// </summary>
        [DataMember(Name="matching_algorithm", EmitDefaultValue=true)]
        public long MatchingAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets IsInsensitive
        /// </summary>
        [DataMember(Name="is_insensitive", EmitDefaultValue=true)]
        public bool IsInsensitive { get; set; }

        /// <summary>
        /// Gets or Sets DocumentCount
        /// </summary>
        [DataMember(Name="document_count", EmitDefaultValue=true)]
        public long DocumentCount { get; set; }

        /// <summary>
        /// Gets or Sets LastCorrespondence
        /// </summary>
        [DataMember(Name="last_correspondence", EmitDefaultValue=false)]
        public DateTime LastCorrespondence { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCorrespondent {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  MatchingAlgorithm: ").Append(MatchingAlgorithm).Append("\n");
            sb.Append("  IsInsensitive: ").Append(IsInsensitive).Append("\n");
            sb.Append("  DocumentCount: ").Append(DocumentCount).Append("\n");
            sb.Append("  LastCorrespondence: ").Append(LastCorrespondence).Append("\n");
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((NewCorrespondent)obj);
        }

        /// <summary>
        /// Returns true if NewCorrespondent instances are equal
        /// </summary>
        /// <param name="other">Instance of NewCorrespondent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewCorrespondent other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Match == other.Match ||
                    Match != null &&
                    Match.Equals(other.Match)
                ) && 
                (
                    MatchingAlgorithm == other.MatchingAlgorithm ||
                    
                    MatchingAlgorithm.Equals(other.MatchingAlgorithm)
                ) && 
                (
                    IsInsensitive == other.IsInsensitive ||
                    
                    IsInsensitive.Equals(other.IsInsensitive)
                ) && 
                (
                    DocumentCount == other.DocumentCount ||
                    
                    DocumentCount.Equals(other.DocumentCount)
                ) && 
                (
                    LastCorrespondence == other.LastCorrespondence ||
                    LastCorrespondence != null &&
                    LastCorrespondence.Equals(other.LastCorrespondence)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Match != null)
                    hashCode = hashCode * 59 + Match.GetHashCode();
                    
                    hashCode = hashCode * 59 + MatchingAlgorithm.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsInsensitive.GetHashCode();
                    
                    hashCode = hashCode * 59 + DocumentCount.GetHashCode();
                    if (LastCorrespondence != null)
                    hashCode = hashCode * 59 + LastCorrespondence.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NewCorrespondent left, NewCorrespondent right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NewCorrespondent left, NewCorrespondent right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
