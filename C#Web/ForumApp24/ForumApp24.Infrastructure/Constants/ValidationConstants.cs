using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp24.Infrastructure.Constants
{   /// <summary>
/// Validation Constants
/// </summary>
    public static class ValidationConstants
    {
        /// <summary>
        /// Maximal Post Title Length
        /// </summary>
        public const int titleMaxLength = 50;

        /// <summary>
        /// Minimal Post Title Length
        /// </summary>
        public const int titleMinLength = 10;

        /// <summary>
        /// Maximal Post Content Length
        /// </summary>
        public const int contentMaxLength = 1500;

        /// <summary>
        /// Minimal Post Content Length
        /// </summary>
        public const int contentMinLength = 30;

        /// <summary>
        /// Reqire Error message text
        /// </summary>
        public const string RequireErrorMessage = "The {0} field is required";

        public const string StringLengthErrorMessage = "The {0} field mudt be between {2} and {1} characters long";

    }
}
