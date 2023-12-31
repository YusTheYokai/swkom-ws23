using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest.Model {
    /// <summary>
    /// 
    /// </summary>
    [Table("user_info")]
    public partial class UserInfo : Entity, IEquatable<UserInfo> {

        [Column("id"), Key]
        public long Id { get; set; }


        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [Column("username"), Required]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [Column("password"), MaxLength(70), Required]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfo {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserInfo)obj);
        }

        /// <summary>
        /// Returns true if UserInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of UserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfo other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
                ) && 
                (
                    Password == other.Password ||
                    Password != null &&
                    Password.Equals(other.Password)
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
                    if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
                    if (Password != null)
                    hashCode = hashCode * 59 + Password.GetHashCode();
                return hashCode;
            }
        }

        public override long GetId() {
            return Id;
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UserInfo left, UserInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserInfo left, UserInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
