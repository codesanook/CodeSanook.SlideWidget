using Orchard.ContentManagement;

namespace CodeSanook.SlideWidget.Models
{
    public class SlideWidgetPart : ContentPart<SlideWidgetPartRecord>
    {
        public int NumberOfItemsInSlide
        {
            get { return Record.NumberOfItemsInSlide; }
            set { Record.NumberOfItemsInSlide = value; }
        }
    }
}