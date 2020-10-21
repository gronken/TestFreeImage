using Microsoft.Xna.Framework.Content.Pipeline;

using TInput = FreeImagePipline.FreeImageEditedFile;
using TOutput = FreeImagePipline.FreeImageEditedFile;

namespace FreeImagePipline
{
    [ContentProcessor(DisplayName = "FreeImageEditProcessor")]
    class FreeImageEditProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(TInput input, ContentProcessorContext context)
        {
            //return default(TOutput);
            return input; 
        }
    }
}
