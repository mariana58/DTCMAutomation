﻿using Microsoft.Dynamics365.UIAutomation.Api;
using Microsoft.Dynamics365.UIAutomation.Browser;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTCM_Automation.project
{
    public static class TestSettings
    {
        public static string InvalidAccountLogicalName = "accounts";

        public static string LookupField = "primarycontactid";
        public static string LookupName = "Rene Valdes (sample)";
        private static readonly string Type = Properties.Settings.Default.BrowserType.ToString();
        public static BrowserOptions Options = new BrowserOptions
        {
            BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), Type),
            PageLoadStrategyValue = OpenQA.Selenium.PageLoadStrategy.None,
            PrivateMode = true,
            FireEvents = true,
            Headless = false,
            UserAgent = false
        };
    }
    ////public class Testsettings
    //// {
    ////     public static string InvalidAccountLogicalName = "accounts";

    ////     public static LookupItem LookupValues = new LookupItem { Name = "primarycontactid", Value = "Nancy Anderson (sample)" };
    ////     public static string LookupField = "primarycontactid";
    ////     public static string LookupName = "Nancy Anderson (sample)";
    ////     private static readonly string Type = ConfigurationManager.AppSettings["BrowserType"];
    ////     private static readonly string RemoteType = ConfigurationManager.AppSettings["RemoteBrowserType"];
    ////     private static readonly string RemoteHubServerURL = ConfigurationManager.AppSettings["RemoteHubServer"];
    ////     private static readonly string DriversPath = ConfigurationManager.AppSettings["DriversPath"] ?? string.Empty;
    ////     private static readonly bool UsePrivateMode = Convert.ToBoolean(ConfigurationManager.AppSettings["UsePrivateMode"] ?? bool.TrueString);

    ////     // Once you change this instance will affect all follow tests executions
    ////     public static BrowserOptions SharedOptions = new BrowserOptions
    ////     {
    ////         BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), Type),
    ////         PrivateMode = UsePrivateMode,
    ////         FireEvents = false,
    ////         Headless = false,
    ////         UserAgent = false,
    ////         DefaultThinkTime = 2000,
    ////         RemoteBrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), RemoteType),
    ////         RemoteHubServer = new Uri(RemoteHubServerURL),
    ////         UCITestMode = true,
    ////         UCIPerformanceMode = true,
    ////         DriversPath = Path.IsPathRooted(DriversPath) ? DriversPath : Path.Combine(Directory.GetCurrentDirectory(), DriversPath)
    ////     };

    ////     // Create a new options instance, copy of the share, to use just in the current test, modifications in test will not affect other tests
    ////     public static BrowserOptions Options => new BrowserOptions
    ////     {
    ////         BrowserType = SharedOptions.BrowserType,
    ////         PrivateMode = SharedOptions.PrivateMode,
    ////         FireEvents = SharedOptions.FireEvents,
    ////         Headless = SharedOptions.Headless,
    ////         UserAgent = SharedOptions.UserAgent,
    ////         DefaultThinkTime = SharedOptions.DefaultThinkTime,
    ////         RemoteBrowserType = SharedOptions.RemoteBrowserType,
    ////         RemoteHubServer = SharedOptions.RemoteHubServer,
    ////         UCITestMode = SharedOptions.UCITestMode,
    ////         UCIPerformanceMode = SharedOptions.UCIPerformanceMode,
    ////         DriversPath = SharedOptions.DriversPath
    ////     };

    ////     public static string GetRandomString(int minLen, int maxLen)
    ////     {
    ////         char[] Alphabet = ("ABCDEFGHIJKLMNOPQRSTUVWXYZabcefghijklmnopqrstuvwxyz0123456789").ToCharArray();
    ////         Random m_randomInstance = new Random();
    ////         Object m_randLock = new object();

    ////         int alphabetLength = Alphabet.Length;
    ////         int stringLength;
    ////         lock (m_randLock) { stringLength = m_randomInstance.Next(minLen, maxLen); }
    ////         char[] str = new char[stringLength];

    ////         // max length of the randomizer array is 5
    ////         int randomizerLength = (stringLength > 5) ? 5 : stringLength;

    ////         int[] rndInts = new int[randomizerLength];
    ////         int[] rndIncrements = new int[randomizerLength];

    ////         // Prepare a "randomizing" array
    ////         for (int i = 0; i < randomizerLength; i++)
    ////         {
    ////             int rnd = m_randomInstance.Next(alphabetLength);
    ////             rndInts[i] = rnd;
    ////             rndIncrements[i] = rnd;
    ////         }

    ////         // Generate "random" string out of the alphabet used
    ////         for (int i = 0; i < stringLength; i++)
    ////         {
    ////             int indexRnd = i % randomizerLength;
    ////             int indexAlphabet = rndInts[indexRnd] % alphabetLength;
    ////             str[i] = Alphabet[indexAlphabet];

    ////             // Each rndInt "cycles" characters from the array, 
    ////             // so we have more or less random string as a result
    ////             rndInts[indexRnd] += rndIncrements[indexRnd];
    ////         }
    ////         return (new string(str));
    ////     }
    //// }

    public static class UCIAppName
    {
        public const string Sales = "Sales Hub";
        public const string CustomerService = "Customer Service Hub";
        public const string Project = "Project Resource Hub";
        public const string FieldService = "Field Resource Hub";
    }

}

