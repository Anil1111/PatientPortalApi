﻿using System.Net.Http;
using System.Threading.Tasks;

namespace OnSolve.Mobile.Web.Infrastructure.Adaptors
{
    public interface IHttpNotificationClient
    {
        Task<HttpResponseMessage> SendPost<T>(T message, string callback, string secret) where T : new();
    }
}
