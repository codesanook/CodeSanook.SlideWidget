using CodeSanook.SlideWidget.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using CodeSanook.Common.Data;

namespace CodeSanook.SlideWidget
{
    public class Migrations : DataMigrationImpl
    {
        public int Create()
        {
            // create table  
            SchemaBuilder.CreateTable<SlideWidgetPartRecord>(tableConfig => tableConfig
                .ContentPartRecord()
                .Column<SlideWidgetPartRecord, int>(table => table.NumberOfItemsInSlide)
            );

            //create part
            ContentDefinitionManager.AlterPartDefinition(
                nameof(SlideWidgetPart), cfg => cfg.Attachable()
            );

            //create widget 
            ContentDefinitionManager.AlterTypeDefinition("SlideWidget", cfg => cfg
                .WithPart(nameof(SlideWidgetPart))
                .AsWidget()
            );

            return 1;
        }
    }
}