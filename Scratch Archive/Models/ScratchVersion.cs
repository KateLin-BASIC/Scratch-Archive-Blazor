using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scratch_Archive.Models
{
    public abstract class ScratchVersion
    {
        protected ScratchVersion(byte id, string name, string fileUrl)
        {
            Id = id;
            Name = name;
            FileUrl = fileUrl;
        }

        public byte Id { get; }
        public string Name { get; }
        public string FileUrl { get; }
    }
}