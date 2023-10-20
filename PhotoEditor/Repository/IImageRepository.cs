namespace PhotoEditor.Repository
{
    public interface IImageRepository
    {
        IEnumerable<Image> ShowAll();
        void Add(Image image);
        void Delete(int? id);
        Image GetImageByID(int? id);
    }
}
