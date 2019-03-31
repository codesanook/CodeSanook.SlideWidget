using CodeSanook.SlideWidget.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace CodeSanook.SlideWidget.Drivers
{
    public class SlidWidgetPartDriver : ContentPartDriver<SlideWidgetPart>
    {
        protected override DriverResult Display(SlideWidgetPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_SlideWidget",
                () => shapeHelper.Parts_SlideWidget(SlideWidgetPart: part));
            //This will render View/Parts/SlideWidget.cshtml with model which has NumberOfItemInSlide property
        }

        //GET
        protected override DriverResult Editor(SlideWidgetPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_SlideWidget_Edit", //just key name
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/SlideWidget", //in EditorTemplates folder
                    Model: part,
                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(SlideWidgetPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}