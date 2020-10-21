using FreeImageAPI;
using Microsoft.Xna.Framework.Content.Pipeline;

using TImport = FreeImagePipline.FreeImageEditedFile;

namespace FreeImagePipline
{
    [ContentImporter(".bmp", DisplayName = "Test Freeimage", DefaultProcessor = "FreeImageEditProcessor")]
    public class FreeImageEditImporter : ContentImporter<TImport>
    {
        public override TImport Import(string filename, ContentImporterContext context)
        {

            FIBITMAP image = FreeImage.Allocate(100, 100, 24);   //If you comment out this line and rebulid everything will work "fine".
            
            return new FreeImageEditedFile(null);
        }
    }
}
