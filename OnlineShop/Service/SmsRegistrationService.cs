using System;
using System.Collections.Generic;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace OnlineShop.Service
{
    public class SmsRegistrationService
    {
        private string accountSid = "AC03798a1882921c7f150d85a1f9967321";
        private string authToken = "ad39026ddd99dc8700deba5d111d5f89";

        public SmsRegistrationService()
        {
            TwilioClient.Init(accountSid, authToken);
        }

        public bool Registration(string phone)
        {
            Random random = new Random();
            int randomCode = random.Next(100000, 999999);

            var to = new PhoneNumber(phone);
            var from = new PhoneNumber("+12059473430");

            var message = MessageResource.Create(
                to: to,
                from: from,
                body: randomCode.ToString()
            );

            Console.WriteLine("На ваш номер был выслан код");
            Console.Write("Введите код для подверждения: ");
            int inputCode = int.Parse(Console.ReadLine());

            if (randomCode == inputCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
