using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Enum
{
    public enum ResponseTypes
    {
        /// <summary>
        /// everything is ok
        /// </summary>
        ok, // everything is ok

        /// <summary>
        ///  input Error
        /// </summary>
        Error, // input Error
               /// <summary>
               ///  parameter error
               /// </summary>
        invalid, // parameter error

        /// <summary>
        /// SessionOut
        /// </summary>
        sessionOut, // SessionOut

        /// <summary>
        /// wrong Password
        /// </summary>
        loginFailed,
        /// <summary>
        ///Invalid File Format
        /// </summary>
        invalidFile,
        /// <summary>
        /// no file in request to upload
        /// </summary>
        noFile,
        /// <summary>
        /// when no data Exists
        /// </summary>
        noData,
        /// <summary>
        /// EmailAlreadyExists
        /// </summary>
        UserAlreadyExists,
        /// <summary>
        /// sql error
        /// </summary>
        unknownerror,//sql error		  ,
                     /// <summary>
                     /// filter Profile	 confirmation
                     /// </summary>
        filterProfile

    }
}
