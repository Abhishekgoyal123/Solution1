using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CS_MemoryStream
{
    
    public class abcd
    {
        public byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn is null)
            {
                throw new ArgumentNullException(nameof(imageIn));
            }

            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

    }
   
}
