using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using AWS;

namespace AWSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "AKIA4K2QXU557RGJTE4F";
            string secret = "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";

            ContactsRepository repo = new ContactsRepository(key, secret);
            var contact = new Contact();
            contact.MobileNumber = "084294738947289";
            contact.OtherDetails = new System.Collections.Specialized.NameValueCollection();
            contact.OtherDetails.Add("Name", "Jalaluddin");
            contact.OtherDetails.Add("BirthDate", "2/2/2001");

            repo.Add(contact);
        }
    }
}
