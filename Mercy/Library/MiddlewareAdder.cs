﻿using Mercy.Models.Abstract;
using Mercy.Models.Conditions;
using Mercy.Models.Middlewares;
using Mercy.Models.Workers;
using Mercy.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercy.Library
{
    public static class MiddlewareAdder
    {
        public static IMiddleware UseDefaultHeaders(this IMiddleware host, string serverName = "Mercy", bool keepAlive = true)
        {
            return host.InsertMiddleware(new DefaultHeadersMiddleware(serverName, keepAlive));
        }

        public static IMiddleware UseDefaultFile(this IMiddleware host, string location, string fileName = "index.html")
        {
            return host.InsertMiddleware(new DefaultFileMiddleware(location, fileName));
        }

        public static IMiddleware UseStaticFile(this IMiddleware host, string rootPath)
        {
            return host.InsertMiddleware(new StaticFileMiddleware(rootPath));
        }

        public static IMiddleware UseMvc(this IMiddleware host,string viewLocation, ServiceGroup services,bool checkPathCase)
        {
            return host.InsertMiddleware(new MvcMiddleware(viewLocation,services, checkPathCase));
        }

        public static IMiddleware UseNotFound(this IMiddleware host, string root, string errorPage)
        {
            return host.InsertMiddleware(new NotFoundMiddleware(root, errorPage));
        }

        public static IServer UseDefaultBuilder(this IServer server)
        {
            return server.UseBuilder(new HttpBuilder());
        }
        public static IServer UseDefaultReporter(this IServer server)
        {
            return server.UseReporter(new HttpReporter());
        }
        public static IServer UseDefaultRecorder(this IServer server, bool recordIncoming = false)
        {
            return server.UseRecorder(new HttpRecorder(recordIncoming));
        }

        public static ICondition UseDomainCondition(this ICondition condition, string domain)
        {
            return condition.InsertCondition(new DomainCondition(domain));
        }
    }
}
