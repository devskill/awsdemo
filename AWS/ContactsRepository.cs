using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWS
{
    public class ContactsRepository
    {
        private AmazonDynamoDBClient client;
        public ContactsRepository(string key, string secret)
        {
            client = new AmazonDynamoDBClient(key, secret, Amazon.RegionEndpoint.USEast1);
        }
        public void Add(Contact contact)
        {
            PutItemRequest request = new PutItemRequest();
            request.TableName = "Contacts";
            request.Item = new Dictionary<string, AttributeValue>()
                    {
                        { "MobileNumber", new AttributeValue { S = contact.MobileNumber }},
                    };

            foreach(string key in contact.OtherDetails.AllKeys)
            {
                request.Item.Add(key, new AttributeValue { S = (string)contact.OtherDetails[key] });
            }

            var response = client.PutItemAsync(request).Result;
        }

        public void Delete(Contact contact)
        {

        }

        public void Update (Contact contact)
        {

        }

        //public ICollection<Contact> Get(Guid groupId)
        //{

        //}
        //public Contact Get(string mobileNumber)
        //{

        //}

    }
}
