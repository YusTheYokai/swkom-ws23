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
    public partial class NewTag : IEquatable<NewTag> {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=true)]
        public string Color { get; set; }

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
        /// Gets or Sets IsInboxTag
        /// </summary>
        [DataMember(Name="is_inbox_tag", EmitDefaultValue=true)]
        public bool IsInboxTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewTag {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  MatchingAlgorithm: ").Append(MatchingAlgorithm).Append("\n");
            sb.Append("  IsInsensitive: ").Append(IsInsensitive).Append("\n");
            sb.Append("  IsInboxTag: ").Append(IsInboxTag).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NewTag)obj);
        }

        /// <summary>
        /// Returns true if NewTag instances are equal
        /// </summary>
        /// <param name="other">Instance of NewTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewTag other)
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
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
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
                    IsInboxTag == other.IsInboxTag ||
                    
                    IsInboxTag.Equals(other.IsInboxTag)
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
                    if (Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();
                    if (Match != null)
                    hashCode = hashCode * 59 + Match.GetHashCode();
                    
                    hashCode = hashCode * 59 + MatchingAlgorithm.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsInsensitive.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsInboxTag.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NewTag left, NewTag right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NewTag left, NewTag right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
