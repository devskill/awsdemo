using System.Collections.Specialized;

namespace AWS
{
    public class Contact
    {
        public string MobileNumber { get; set; }
        public NameValueCollection OtherDetails { get; set; }
    }
}