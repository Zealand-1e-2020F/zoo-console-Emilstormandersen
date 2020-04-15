using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    /// <summary>
    /// base klasse for dyr i zoo
    /// </summary>
    public class Insekt : Dyr
    {
        public string Insektnavn { get; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Insekt()
        {

        }

        /// <summary>
        /// cosntructor som tager dyrenavn som parameter
        /// </summary>
        /// <param name="navn">navnet på typen af dyr</param>
        public Insekt(string navn)
        {
            this.Insektnavn = navn;

        }


    }
}
