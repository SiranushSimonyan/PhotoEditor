namespace PhotoEditor
{
    public class Image
    {
        #region Properties
        public int? ImageID { get; set; }
        public string? ImageName { get; set; }
        public string? ImagePath { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? Size { get; set; }
        public decimal? Radius { get; set; }
        public bool? Effect1Applied { get; set; }
        public bool? Effect2Applied { get; set; }
        public bool? Effect3Applied { get; set; }
        #endregion

        #region Ctor
        public Image() { }

        public Image(string? imageName, string? imagePath, DateTime? createdDate, decimal? size, decimal? radius, bool? effect1Applied, bool? effect2Applied, bool? effect3Applied)
        {
            ImageName = imageName;
            ImagePath = imagePath;
            CreatedDate = createdDate;
            Size = size;
            Radius = radius;
            Effect1Applied = effect1Applied;
            Effect2Applied = effect2Applied;
            Effect3Applied = effect3Applied;
        }
        #endregion
    }
}