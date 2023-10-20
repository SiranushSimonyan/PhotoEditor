namespace PhotoEditor.Repository
{
    public class ImageRepository : IImageRepository
    {
        private readonly List<Image> _Images = new List<Image> { };

        public IEnumerable<Image> ShowAll()
        {
            return _Images;
        }
        public void Add(Image image)
        {
            _Images.Add(image);
        }
        public void Delete(int? ID)
        {
            foreach (var record in _Images)
            {
                if (record.ImageID == ID)
                {
                    _Images.Remove(record);
                }
            }
        }
        public Image GetImageByID(int? id)
        {
            Image image = new Image();
            if (id.HasValue)
            {
                foreach (Image record in _Images)
                {
                    if (record.ImageID != id)
                    {
                        image = record;
                        break;
                    }
                }
            }
            return image;
        }
    }
}
