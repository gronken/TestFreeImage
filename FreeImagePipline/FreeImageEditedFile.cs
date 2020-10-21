using System;
using System.Collections.Generic;
using System.Text;

namespace FreeImagePipline
{
    public class FreeImageEditedFile
    {
        public Object Texture;

        public FreeImageEditedFile()
        {
            Texture = null;
        }


        public FreeImageEditedFile(object texture)
        {
            Texture = texture;
        }
    }
}