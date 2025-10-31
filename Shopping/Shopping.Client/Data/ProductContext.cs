using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>
        {
        new Product()
        {
            Name = "MacBook Pro 14\"",
            Description = "A powerful laptop featuring Apple's M3 Pro chip, Liquid Retina XDR display, and all-day battery life.",
            ImageFile = "product-laptop-1.png",
            Price = 1999.00M,
            Category = "Laptops"
        },
        new Product()
        {
            Name = "Dell XPS 13",
            Description = "A premium ultrabook with 13-inch InfinityEdge display, Intel i7 processor, and lightweight aluminum design.",
            ImageFile = "product-laptop-2.png",
            Price = 1399.00M,
            Category = "Laptops"
        },
        new Product()
        {
            Name = "Sony WH-1000XM5",
            Description = "Industry-leading noise-canceling headphones with 30-hour battery life and immersive sound quality.",
            ImageFile = "product-audio-1.png",
            Price = 349.00M,
            Category = "Audio Devices"
        },
        new Product()
        {
            Name = "Apple Watch Series 9",
            Description = "Advanced smartwatch with fitness tracking, ECG, temperature sensing, and seamless iPhone integration.",
            ImageFile = "product-watch-1.png",
            Price = 429.00M,
            Category = "Wearables"
        },
        new Product()
        {
            Name = "Ninja Air Fryer Max XL",
            Description = "Cooks food with up to 75% less fat using rapid air technology, with easy cleanup and multiple presets.",
            ImageFile = "product-kitchen-1.png",
            Price = 169.00M,
            Category = "Home Kitchen"
        },
        new Product()
        {
            Name = "Philips Hue Starter Kit",
            Description = "Smart LED bulb kit controllable via mobile app or voice assistants with millions of color options.",
            ImageFile = "product-light-1.png",
            Price = 119.00M,
            Category = "Smart Home"
        },
        new Product()
        {
            Name = "Canon EOS R50",
            Description = "Mirrorless camera with 4K video recording, Dual Pixel autofocus, and compact lightweight design.",
            ImageFile = "product-camera-1.png",
            Price = 799.00M,
            Category = "Cameras"
        },
        new Product()
        {
            Name = "Google Pixel 8",
            Description = "A flagship smartphone with advanced AI-powered camera features and Google Tensor G3 processor.",
            ImageFile = "product-phone-1.png",
            Price = 899.00M,
            Category = "Smart Phone"
        },
        new Product()
        {
            Name = "Samsung Galaxy Tab S9",
            Description = "High-performance Android tablet with AMOLED display and S Pen support for productivity and creativity.",
            ImageFile = "product-tablet-1.png",
            Price = 999.00M,
            Category = "Tablets"
        },
        new Product()
        {
            Name = "Dyson V15 Detect",
            Description = "Cordless vacuum cleaner with laser dust detection and powerful suction for deep home cleaning.",
            ImageFile = "product-home-1.png",
            Price = 749.00M,
            Category = "Home Appliances"
        }

        };
    }
}
