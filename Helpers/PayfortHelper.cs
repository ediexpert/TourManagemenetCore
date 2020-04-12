using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace AuthWithIdentity.Helpers
{
    public class PayfortHelper
    {
        private object ReturnUrl;

        public PayfortHelper()
        {
            PAYFORT.PayFortConfig.access_code = System.Configuration.ConfigurationManager.AppSettings["access_code"].ToString();
            PAYFORT.PayFortConfig.language = System.Configuration.ConfigurationManager.AppSettings["language"].ToString();
            PAYFORT.PayFortConfig.merchant_identifier = System.Configuration.ConfigurationManager.AppSettings["merchant_identifier"].ToString();
            PAYFORT.PayFortConfig.SHA_RequestPhase = System.Configuration.ConfigurationManager.AppSettings["sha_request"].ToString();
            PAYFORT.PayFortConfig.SHA_ResponsePhase = System.Configuration.ConfigurationManager.AppSettings["sha_response"].ToString();
            int sand = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["sandbox"].ToString());
            PAYFORT.PayFortConfig.SandBoxMode = Convert.ToBoolean(sand);
            ReturnUrl = ConfigurationManager.AppSettings["return_url"].ToString();
            if (System.Configuration.ConfigurationManager.AppSettings["sha_type"].ToString() == "SHA-256")
            {
                PAYFORT.PayFortConfig.sha_type = PAYFORT.Security.SHA_Type.SHA_256;
            }
            else
            {
                PAYFORT.PayFortConfig.sha_type = PAYFORT.Security.SHA_Type.SHA_512;
            }
        }


        public void SendRequest(string command, string merchantRef, decimal amount,string currency, string custEmail, string tokenName, string custIp)
        {

            ArrayList trans = new ArrayList();
            trans.Add($"command={command}");
            trans.Add($"merchant_reference={merchantRef}");
            trans.Add($"amount={amount}");
            trans.Add($"currency={currency}");
            trans.Add($"customer_email={custEmail}");
            trans.Add($"token_name={tokenName}");
            trans.Add($"return_url={ReturnUrl}");
            trans.Add($"customer_ip={custIp}");

            ArrayList payfort_response = new ArrayList();
            payfort_response = PAYFORT.Command.SendRequestToPayFORT(trans);

        }
        public void GenerateSignature(HttpRequest Request)
        {
            

            //Dictionary<string, string> pars = new Dictionary<string, string>();
            //pars.Add("access_code", PAYFORT.PayFortConfig.access_code);
            //pars.Add("language", PAYFORT.PayFortConfig.language);
            //pars.Add("merchant_reference", PAYFORT.PayFortConfig.merchant_identifier);
            //var s = pars.ToArray();

            //foreach (var item in pars)
            //{
            //    var s = item.ToString()
            //}

            //Generate signature
            string[] pars = { "access_code=XX", "language=en", "merchant_reference=blabla" };
            string Signature = PAYFORT.Security.GenerateSignature(pars);

            //Validate signature
            string[] parsVal = { "access_code=XX", "language=en", "merchant_reference=blabla" };
            Boolean isValid = PAYFORT.Security.ValidateSignature(parsVal);

            //Send Request to Payfort
            string[] parsReq = { "access_code=XX", "language=en", "merchant_reference=blabla" };
            string[] response = PAYFORT.Command.SendRequestToPayFORT(parsReq);


            //Get Payfort Response
            //string[] response = PAYFORT.Command.GetPAYFORTResponse(Request.QueryString);

            //API Url
            string _url = PAYFORT.Command.GetAPIURL(PAYFORT.Command.IntegrationTypes.Host_to_Host, true);




        }
    }
}
