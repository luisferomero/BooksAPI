using System;
using System.Collections.Generic;
using System.Text;

namespace BooksAPI.BusinessLogic.Responses
{
    public class ResultResponse
    {
        public ResultResponse()
        {
            Messages = new List<string>();
        }
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }
        public List<string> Messages { get; set; }

    }
}
