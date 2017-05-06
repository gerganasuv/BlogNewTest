﻿using OpenQA.Selenium.Chrome;
using TestStack.Seleno.Configuration;

namespace Blog.UI.Tests
{
    class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl;

        static BrowserHost()
        {
            //Instance.Run("Blog", 60639, c => c.WithRouteConfig(RouteConfig.RegisterRoutes));
            Instance.Run("Blog", 10639, w => w.WithRemoteWebDriver(() => new ChromeDriver()));

            //RootUrl = Instance.Application.Browser.Url;
            RootUrl = @"http://localhost:60634/";


        }
    }
}
