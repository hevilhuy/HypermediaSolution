using System.Collections.Generic;

namespace HypermediaAPI.Models
{
    public class ShoppingLinkItemProfile : ILinkProfile
    {
        public ShoppingLinkItemProfile()
        {
            Links = new()
            {
                new()
                {
                    Href = "create_child",
                    Rel = "shopping/create/child/{id}"
                }
            };
        }

        public List<Link> Links { get; init; }
    }
}
