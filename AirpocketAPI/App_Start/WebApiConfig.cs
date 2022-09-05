﻿using AirpocketAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.OData.Builder;

namespace AirpocketAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.Services.Add(typeof(IExceptionLogger), new TraceExceptionLogger());
            config.EnableCors();
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<RptFlight>("RptFlights");
            config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback
            (
            delegate { return true; }
            );

        }
    }

    public class TraceExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            var xxx = context.Request;
            Trace.TraceError(context.ExceptionContext.Exception.ToString());
        }
    }
}
