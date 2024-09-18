using FitSwipe.Shared.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitSwipe.Shared.Dtos.Tags
{
    public class UpdateTagDto
    {
        [Required] 
        public required Guid Id { get; set; }

        public string? Name { get; set; }
        public TagType? TagType { get; set; }
        public string? TagImage { get; set; }
    }
}
