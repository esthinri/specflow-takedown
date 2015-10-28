﻿using EasyHttp.Http;
using System;

namespace specflow_takedown.Support
{
    public static class HttpClient
    {
        public static HttpResponse Get(string uri)
        {
            var httpClient = new EasyHttp.Http.HttpClient();
            httpClient.Request.Accept = HttpContentTypes.ApplicationJson;
            httpClient.Request.Timeout = Convert.ToInt32(TimeSpan.FromSeconds(10).TotalMilliseconds);

            return httpClient.Get(uri);
        }
    }
}
