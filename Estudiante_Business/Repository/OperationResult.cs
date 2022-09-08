using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Business.Repository
{
 
        public class OperationResult<T> : OperationResult
        {
            public T Result { get; set; }
            public OperationResult()
            {

            }
            public OperationResult(HttpStatusCode statusCode)
            : base(statusCode)
            {
            }

            public OperationResult(bool success, HttpStatusCode statusCode)
                : base(success, statusCode)
            {
            }
        }

        public class OperationResult
        {
            public bool Success { get; set; }
            public string Message { get; set; }
            public HttpStatusCode StatusCode { get; set; }
            public OperationResult()
            {
                Success = false;
                Message = string.Empty;
                StatusCode = 0;
            }

            public OperationResult(HttpStatusCode statusCode)
            {
                Success = false;
                StatusCode = statusCode;
                Message = string.Empty;
            }

            public OperationResult(bool success, HttpStatusCode statusCode)
            {
                Success = success;
                StatusCode = statusCode;
                Message = string.Empty;
            }
        }
    }

