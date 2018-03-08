using System;
using System.IO;
using System.Net;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace TestNext.Util
{
    class CustomRemoteWebDriver : RemoteWebDriver
    {

        public CustomRemoteWebDriver(Uri remoteAddress, ICapabilities desiredCapabilities, TimeSpan commandTimeOut) : base(remoteAddress, desiredCapabilities, commandTimeOut)
        {
        }
        public string GetSessionId()
        {
            return SessionId.ToString();
        }

        public void SetStatus(string session, string status, string userName, string password)
        {
            if (string.IsNullOrEmpty(session))
                return; // Illegal SessionID
            string reqString = "{\"status\":\"" + status + "\", \"reason\":\"\"}";
            byte[] requestData = Encoding.UTF8.GetBytes(reqString);
            Uri myUri = new Uri(string.Format("https://www.browserstack.com/automate/sessions/" + session + ".json"));
            WebRequest myWebRequest = WebRequest.Create(myUri);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myWebRequest.ContentType = "application/json";
            myWebRequest.Method = "PUT";
            myWebRequest.ContentLength = requestData.Length;
            using (Stream st = myWebRequest.GetRequestStream()) st.Write(requestData, 0, requestData.Length);

            NetworkCredential myNetworkCredential = new NetworkCredential(userName, password);
            CredentialCache myCredentialCache = new CredentialCache { { myUri, "Basic", myNetworkCredential } };
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Credentials = myCredentialCache;

            myWebRequest.GetResponse().Close();
        }
    }
}
