using Microsoft.AspNetCore.Mvc;
using PhotoEditor.Repository;

namespace PhotoEditor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageRepository _Images;

        public ImageController(IImageRepository Images)
        {
            _Images = Images;
        }

        [HttpGet]
        public IEnumerable<Image> Index()
        {
            return _Images.ShowAll();
        }

        [HttpPost]
        public IActionResult Browse(string? path)
        {
            Image image;
            if (path != null)
            {
                image = HelperMethods.LoadImage(path);
                if (image != null)
                {
                    _Images.Add(image);
                }
                else
                {
                    throw new Exception("Image not found.");
                }
            }
            //use an existing View instead
            return new ViewResult();
        }
        [HttpPost]
        public IActionResult Apply(Image editedImage)
        {
            if (editedImage != null)
            {
                Image existingImage = _Images.GetImageByID(editedImage.ImageID);
                if (existingImage != null)
                {
                    if (editedImage.Size > 0.0M)
                    {
                       existingImage.Size = editedImage.Size;
                       existingImage.Radius = editedImage.Radius;
                       existingImage.Effect1Applied = editedImage.Effect1Applied;
                       existingImage.Effect2Applied = editedImage.Effect2Applied;
                       existingImage.Effect3Applied = editedImage.Effect3Applied;
                    }
                }
                else
                {
                    throw new Exception("Image not found.");
                }
            }
            //use an existing View instead
            return new ViewResult();
        }
    }
    public static class HelperMethods
    {
        public static Image LoadImage(string? path)
        {
            //some code to load the Image
            return new Image();
        }

    }

}