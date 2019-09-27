using BooksAPI.BusinessLogic.DTOs;
using BooksAPI.BusinessLogic.Responses;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksAPI.BusinessLogic.Services
{
    public class BaseService
    {
        public ValidationResponse Validate(IValidator validator, IBaseDto dto)
        {
            var result = validator.Validate(dto);
            var response = new ValidationResponse { IsValid = result.IsValid };
            result.Errors.ToList().ForEach(x => response.Errors.Add(x.ErrorMessage));
            return response;
        }

        public ResultResponse HandleException(Exception e, int statusCode = 400)
        {
            var response = new ResultResponse { Success = false, StatusCode = statusCode };
            response.Messages.Add(e.Message);
            if (e.InnerException != null)
                response.Messages.Add(e.InnerException.Message);
            return response;
        }

        public ResultResponse Success(object data = null)
        {
            return new ResultResponse { Success = true, Data = data, StatusCode = 200 };
        }

        public ResultResponse Error(List<string> messages)
        {
            return new ResultResponse { Success = false, Messages = messages, StatusCode = 400 };
        }

        public ResultResponse ErrorMessage(string message, int statusCode = 400)
        {
            var messages = new List<string>
            {
                message
            };
            return new ResultResponse { Success = false, Messages = messages, StatusCode = statusCode };
        }

        public ResultResponse SuccessMessage(string message)
        {
            var messages = new List<string>
            {
                message
            };
            return new ResultResponse { Success = false, Messages = messages };
        }
    }
}
