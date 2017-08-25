using System;

namespace SampleCode
{
    /// <summary>  
    ///  Utility Class to generate Random Number
    /// </summary>  
    public class RandomUtility
    {
        /// <summary>
        /// Create Random Number between 6 and 15 and append it with Name.
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>number appended with name</returns>
        public static string GenerateNumber( string name )
        {
            Random rnd = new Random();
            //pseudo random number between 6 and 15
            int number = rnd.Next( 6, 15 );

            return string.Format( "{0} {1}", name, number.ToString() );
        }
    }
}
