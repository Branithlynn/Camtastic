using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Intership.Repository;
using Intership.Entity;


namespace Intership
{
    public partial class Form1 : Form
    {
        private static IWebDriver driver;
        private static CameraRepo cameraRepository;
        private static PhotoRepo photoRepository;
        public Form1()
        {
            InitializeComponent();
            cameraRepository = new CameraRepo();
            photoRepository = new PhotoRepo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            if (!url.Contains("https://photo-forum.net/i/"))
            {
                Response.Text = "URL is invalid!";
                return;
            }

            else
            {

                driver = new ChromeDriver(@"D:\Downloald");
                driver.Navigate().GoToUrl(url);

                
                string brand = "";
                string model = "";
                try
                {
                    brand = driver.FindElement(By.XPath("/html/body/div[4]/div[5]/div[1]/div[1]/div/div[2]/div/div[2]/div[1]/div[2]/span"))
                        .GetAttribute("textContent");
                    model = driver.FindElement(By.XPath("/html/body/div[4]/div[5]/div[1]/div[1]/div/div[2]/div/div[2]/div[2]/div[2]/span"))
                        .GetAttribute("textContent");
                }
                catch (Exception ex)
                {
                    Response.Text = "The photo is deleted or it does not exist!";
                    return;
                }

                DateTime date;
                if (DateTime.TryParse(brand, out date))
                {
                    Response.Text = "There is no metadata for the photo!";
                    return;
                }
                Camera camera = new Camera();
                camera.BrandName = brand;
                camera.Model = model;

                cameraRepository.Add(camera);

                int rating = int.Parse(driver.FindElement(By.XPath("/html/body/div[4]/div[5]/div[2]/div/div/div[2]/div/ul[1]/li[1]/ul/li[1]/span[2]/span")).Text);
                Photo photo = new Photo();
                photo.PhotoURL = url;
                photo.Rating = rating;
                photo.CameraId = cameraRepository.FindCamera(brand, model).Id;
                photo.camera = cameraRepository.FindCamera(brand, model);

                photoRepository.Add(photo);
                string message = $"Photo: \n" +
                    $"URL: {photo.PhotoURL}\n Rating: {photo.Rating}\\n" +
                    $"Camera: \n " +
                    $"Brand: {brand}\n Model: {model}";
                Response.Text = "Successfully added!";
                Result.Text = message;
            }
            
        }               

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowCameras_Click_1(object sender, EventArgs e)
        {
            CameraRepo cameraRepo = new CameraRepo();
            List<Camera> cameras = cameraRepo.ShowAll();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Camera camera in cameras)
            {
                stringBuilder.Append($"Id: {camera.Id}\n"+$" BrandName: {camera.BrandName}\n"+$"Model: {camera.Model}\n");
                stringBuilder.Append(Environment.NewLine);
            }
            Result.Text = stringBuilder.ToString();
        }

        private void ShowPhotos_Click(object sender, EventArgs e)
        {
            PhotoRepo photoRepo = new PhotoRepo();
            List<Photo> photos = photoRepo.ShowAll();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Photo photo in photos)
            {
                stringBuilder.Append($"Id: {photo.Id}" + $" URL: {photo.PhotoURL}" + $"CameraID: {photo.CameraId}");
                stringBuilder.Append(Environment.NewLine);
            }
            Result.Text = stringBuilder.ToString();
        }
    }
}
