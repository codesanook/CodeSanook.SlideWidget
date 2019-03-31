using CodeSanook.SlideWidget.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace CodeSanook.SlideWidget.Handlers
{
    public class SideWidgetPartHandler : ContentHandler
    {
        /// <summary>
        ///override in constructor 
        /// </summary>
        /// <param name="repository"></param>
        public SideWidgetPartHandler(IRepository<SlideWidgetPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}