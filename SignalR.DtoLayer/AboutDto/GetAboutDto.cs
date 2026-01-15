using System;
using System.Collections.Generic;
using System.Text;

namespace SignalR.DtoLayer.AboutDto
{
    public class GetAboutDto
    {
        public int AboutId { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
