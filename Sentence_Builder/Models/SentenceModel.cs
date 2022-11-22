using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sentence_Builder.Models
{
    public class SentenceModel
    {
        public List<string> sentences = new List<string>();

        [Required]
        [Display(Name = "Word Type")]
        public int WordType { get; set; }
        public IEnumerable<SelectListItem>? WordTypes { get; set; }

        [Display(Name = "Word List")]
        public string? Word { get; set; }
        public IEnumerable<SelectListItem>? Words { get; set; }
    }
}
