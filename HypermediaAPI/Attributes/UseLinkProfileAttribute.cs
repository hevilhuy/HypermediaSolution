using HypermediaAPI.Models;
using Newtonsoft.Json;
using System;
using System.Text;

namespace HypermediaAPI.Attributes
{
    public class UseLinkProfileAttribute : Attribute
    {
        public UseLinkProfileAttribute(ILinkProfile linkProfile)
        {
            LinkProfile = linkProfile;
        }

        public ILinkProfile LinkProfile { get; }

        public byte[] ToByteArray()
        {
            byte[] result = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(LinkProfile));

            return result;
        }
    }
}
