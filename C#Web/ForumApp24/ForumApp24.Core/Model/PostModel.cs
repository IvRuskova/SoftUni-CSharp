using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ForumApp24.Infrastructure.Constants.ValidationConstants;

namespace ForumApp24.Core.Model
{
    /// <summary>
    /// Post data transfer model  
    /// </summary>
    public class PostModel
    {
        /// <summary>
        /// Post identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Post title
        /// </summary>
        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(titleMaxLength, MinimumLength = titleMinLength, ErrorMessage = StringLengthErrorMessage)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Post content
        /// </summary>
        [Required(ErrorMessage = RequireErrorMessage)]
        [StringLength(contentMaxLength, MinimumLength = titleMinLength, ErrorMessage = StringLengthErrorMessage)]
        public string Content { get; set; } = string.Empty;
    }
}
