using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldAplication.Models
{
    /// <summary>
    /// Isto é uma classe Hello
    /// </summary>
    public class HelloWorldModel
    {
        string _message = "Olá2";
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }
    }
}