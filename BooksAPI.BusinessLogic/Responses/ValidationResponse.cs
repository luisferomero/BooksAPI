using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Responses
{
    public class ValidationResponse
    {
        public ValidationResponse()
        {
            Errors = new List<string>();
        }
        public bool IsValid { get; set; }
        public List<string> Errors { get; set; }
    }
}
