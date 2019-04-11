using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoospaceEventDemo
{
    public class CoospaceDirectory
    {
        public int Size { get; }
        public int ContentSize { get; private set; }
        public int NotificationThresholdContentSize { get; set; }

        //első lépés, meghatározza milyen metódusokkal lehet feliratkozni: paraméterezés!
        // object sender , eventargs -> ez a best practice 
        public delegate void ContentSizeAboveThresholdEventHandler(object sender, ContentSizeAboveThresholdEventArgs e);


        //második lépés: a delegate típust itt használom fel -> létrehozom a saját változómat ahová be lehet majd tenni a feliratkozott metódusokat
        public event ContentSizeAboveThresholdEventHandler ContentSizeAboveThreshold;

        public CoospaceDirectory(int size, int notificationThresholdContentSize)
        {
            Size = size;
            ContentSize = 0;
            NotificationThresholdContentSize = notificationThresholdContentSize;
        }

        //harmadik lépés: el kell dönteni hol érdemes figyelni az eseményt, ott meg is hívom a subscribereket
        public bool UploadContent(int sizeToUpload)
        {
            if (sizeToUpload + ContentSize > Size)
                return false;
            ContentSize += sizeToUpload;
            if (ContentSize > NotificationThresholdContentSize)
            {
                 //itt hívom meg: a kérdőjel azt nézi meg, hogy null-e az event vagy van-e feliratkozója
                 // a paraméterezés adott a delegate miatt
                ContentSizeAboveThreshold?.Invoke(this, new ContentSizeAboveThresholdEventArgs(Size, ContentSize));
            }
            return true;
        }
    }
}
