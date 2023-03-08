using System;

namespace eCommerce.Common
{
    public class ResponseMessage<T>
    {
        public string Message { get; set; }

        public T Data { get; set; }

        public System.Net.HttpStatusCode StatusCode { get; set; }


    }
}
