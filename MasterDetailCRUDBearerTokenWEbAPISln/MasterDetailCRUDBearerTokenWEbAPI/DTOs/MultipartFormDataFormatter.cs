using MasterDetailCRUDBearerTokenWEbAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace MasterDetailCRUDBearerTokenWEbAPI.DTOs
{
    public class MultipartFormDataFormatter : MediaTypeFormatter
    {
        public MultipartFormDataFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("multipart/form-data"));
        }
        public override bool CanReadType(Type type)
        {
            return type == typeof(OrderRequest);
        }

        public override bool CanWriteType(Type type)
        {
            return false;
        }
        public override async Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
        {
            var multipartData = await content.ReadAsMultipartAsync();
            var orderData = new OrderRequest();
            foreach (var item in multipartData.Contents)
            {
                var fieldName = item.Headers.ContentDisposition.Name.Trim('\"');
                if (fieldName == "Order")
                {
                    var orderContent = await item.ReadAsStringAsync();
                    orderData.Order = JsonConvert.DeserializeObject<Order>(orderContent);
                }
                else if (fieldName == "ImageFile")
                {
                    orderData.ImageFile = await item.ReadAsByteArrayAsync();
                    orderData.ImageFileName = item.Headers.ContentDisposition.FileName;
                }
            }
            return orderData;
        }
    }
}