namespace BlogApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public Comment()
        {
            Like = 0;
        }
        public int Id { get; set; }

        public int PostId { get; set; }

        [Required]
        public string Body { get; set; }

        public int Like { get; set; }

        public virtual Post Post { get; set; }
    }
}
