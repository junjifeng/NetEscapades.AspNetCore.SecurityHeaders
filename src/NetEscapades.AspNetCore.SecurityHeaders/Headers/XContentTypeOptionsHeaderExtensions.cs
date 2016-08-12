using NetEscapades.AspNetCore.SecurityHeaders.Infrastructure;

namespace NetEscapades.AspNetCore.SecurityHeaders
{
    /// <summary>
    /// Extension methods for adding a <see cref="XContentTypeOptionsHeader" /> to a <see cref="HeaderPolicyCollection" />
    /// </summary>
    public static class XContentTypeOptionsHeaderExtensions
    {
        /// <summary>
        /// Add X-Content-Type-Options nosniff to all requests.
        /// Can be set to protect against MIME type confusion attacks.
        /// </summary>
        /// <param name="policies">The collection of policies</param>
        public static HeaderPolicyCollection AddContentTypeOptionsNoSniff(this HeaderPolicyCollection policies)
        {
            return policies.ApplyPolicy(XContentTypeOptionsHeader.NoSniff());
        }
    }
}