using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        [Display(Name ="Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset? ModifiedUtc { get; set; }

        //one to many relationship. One category can have many notes
        // [ForeignKey(nameof(Category))] this is another way to setup foreign key below
        public int CategoryID { get; set; }
        //public int? CategoryID { get; set; } made it nullable by adding ? so we don't have to delete the database

        //migrations are only made when you make changes to your data layer so you will make it nullable first then migration is done. So in other word change the code the first then make a migration
        public virtual Category Category { get; set; }//this is where we setup a forigen key which is virtual Category(it is default in DbContext)
       
    }
}
