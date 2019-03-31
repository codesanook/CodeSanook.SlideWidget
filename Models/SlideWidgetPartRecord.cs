using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeSanook.SlideWidget.Models
{
    public class SlideWidgetPartRecord : ContentPartRecord
    {
        public int NumberOfItemsInSlide { get; set; }
    }
}