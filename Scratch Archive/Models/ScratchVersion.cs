using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scratch_Archive.Models
{
    public class ScratchVersion
    {
        public byte Id { get; set; }
        public string? Name { get; set; }
        public string? FileUrl { get; set; }
    }
}