using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sept12_handsonCustomAtt
{


   [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class DeveloperAttribute : Attribute
    {

        public DeveloperAttribute(string _songname)
        {

            this.SongName = _songname;

        }
        public string SongName { get; set; }
        public string Language { get; set; }
        public string Lyrics { get; set; }
    }


}
