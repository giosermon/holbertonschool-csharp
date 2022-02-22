using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Class for image processing methods
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Invert images based on filenames
    /// </summary>
    /// <param name="filenames">List of str filenames to invert</param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach (filenames, file =>
        {
			invert_image(file);
        });
    }

	/// <summary>
	/// Function to invert images
	/// </summary>
	/// <param name="data">File to convert</param>
    public static void invert_image(object data)
    {        
        string file = data.ToString();
        string filename = "";
        string extension = "";

        Bitmap bmp = new Bitmap(file);
        extension = Path.GetExtension(file);
        filename = Path.GetFileNameWithoutExtension(file);
        // Lock the bitmap's bits.  
        Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

        IntPtr ptr = bmpData.Scan0;

        int bytes  = Math.Abs(bmpData.Stride) * bmp.Height;
        byte[] rgbValues = new byte[bytes];

        System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

        // Set every third value to 255. A 24bpp bitmap will look red.  
        for (int i = 0; i < rgbValues.Length; i++)
            rgbValues[i] = (byte)(255 - rgbValues[i]);
        System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

        bmp.UnlockBits(bmpData);
        bmp.Save(filename + "_inverse" + extension);
    }


	/// <summary>
	/// Converts an image to grayscale
	/// </summary>
	/// <param name="filenames">List of image files to convert</param>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach (filenames, file =>
        {
			grayscale_image(file);
        });
    }

	/// <summary>
	/// Converts image to grayscale
	/// </summary>
	/// <param name="data">File to convert</param>
    public static void grayscale_image(object data)
    {        
        string file = data.ToString();
        string filename = "";
        string extension = "";

        Bitmap bmp = new Bitmap(file);
        extension = Path.GetExtension(file);
        filename = Path.GetFileNameWithoutExtension(file);
        // Lock the bitmap's bits.  
        Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

        IntPtr ptr = bmpData.Scan0;

        int bytes  = Math.Abs(bmpData.Stride) * bmp.Height;
        byte[] rgbValues = new byte[bytes];

        System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

        // Set every third value to 255. A 24bpp bitmap will look red.  
        for (int i = 0; i < rgbValues.Length - 3; i += 3)
		{
			byte gray = (byte)(rgbValues[i] * .21 + rgbValues[i + 1] * .71 + rgbValues[i + 2] * .071);
            rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = gray;
		}
        System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
        bmp.UnlockBits(bmpData);
        bmp.Save(filename + "_grayscale" + extension);
    }

    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach (filenames, file =>
        {
			float result;
        	string filename = "";
        	string extension = "";

        	Bitmap bmp = new Bitmap(file);
        	extension = Path.GetExtension(file);
        	filename = Path.GetFileNameWithoutExtension(file);
        	// Lock the bitmap's bits.  
        	Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        	BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);

        	IntPtr ptr = bmpData.Scan0;

        	int bytes  = Math.Abs(bmpData.Stride) * bmp.Height;
        	byte[] rgbValues = new byte[bytes];

        	System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

        	// Set every third value to 255. A 24bpp bitmap will look red.  
        	for (int i = 0; i < rgbValues.Length - 2; i += 3)
			{
				result = rgbValues[i] + rgbValues[i + 1] + rgbValues[i + 2];
				if (result >= threshold)
				{
					rgbValues[i] = 255;
					rgbValues[i + 1] = 255;
					rgbValues[i + 2] = 255;
				}
				else
				{
					rgbValues[i] = 0;
					rgbValues[i + 1] = 0;
					rgbValues[i + 2] = 0;
				}
			}
        	System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
        	bmp.UnlockBits(bmpData);
        	bmp.Save(filename + "_bw" + extension);
        });
    }
	public static void Thumbnail(string[] filenames, int height)
	{
		Parallel.ForEach(filenames, file =>{
			using (Bitmap bmp = new Bitmap(file))
			{
				string extension = Path.GetExtension(file);
        		string filename = Path.GetFileNameWithoutExtension(file);

				int width = height * bmp.Width / bmp.Height;
				Image img  = bmp.GetThumbnailImage(width , height, null, IntPtr.Zero);

				img.Save(filename + "_th" + extension);
			}
		});
	}
}
